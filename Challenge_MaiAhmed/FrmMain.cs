using System.Data;

namespace Challenge_MaiAhmed
{
    public partial class FrmMain : Form
    {
        IDataAccess _dataAccessSource = null;
        public FrmMain()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
        new System.Globalization.CultureInfo("en");
            //............................................................
            InitializeComponent();
            LoadFormControls();

        }

        private void LoadFormControls()
        {
            try
            {
                _dataAccessSource = Factory.CreateDataAccessObj();
                //............................................................
                txtFilePath.Text = Factory.GetDataSourcePath();
                var dataArray = _dataAccessSource.LoadKeyValueData().
                    Select(x => new { Key = x.Key, Value = x.Value }).
                    OrderBy(x => x.Value).ToArray();
                cbxKeyValue.DataSource = dataArray;
                cbxKeyValue.ValueMember = "Key";
                cbxKeyValue.DisplayMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var stationData = _dataAccessSource.LoadData();
                if (stationData.Datarows.Count == 0)
                    return;
                DataTable stationDataTable = new DataTable();
                if (Factory.ColumnNamesExistsInFile)
                {
                    for (int i = 0; i < stationData.ColumnTitles.Count; i++)
                    {
                        if (Factory.ColumnNamesExistsInFile)
                            stationDataTable.Columns.Add(stationData.ColumnTitles[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < stationData.Datarows[0].DataItems.Count; i++)
                    {
                        AddNewColumns(stationDataTable, 1);
                    }
                }
                    
                foreach (var item in stationData.Datarows)
                {
                    var dr = stationDataTable.NewRow();
                    if (item.DataItems.Count > stationDataTable.Columns.Count)
                        AddNewColumns(stationDataTable, item.DataItems.Count - stationDataTable.Columns.Count);
                    dr.ItemArray = item.DataItems.ToArray();
                    stationDataTable.Rows.Add(dr);
                }
                dgvCSVData.DataSource = stationDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Add missing columns if some data has extra columns more than the headers
        /// </summary>
        /// <param name="dataTable">Current loading DataTable</param>
        /// <param name="columnsCount"> Number of columns needs to be added</param>
        private void AddNewColumns(DataTable dataTable, int columnsCount)
        {
            int currentCount = dataTable.Columns.Count;
            for (int i = 0; i < columnsCount; i++)
            {
                dataTable.Columns.Add($" Column {currentCount + i + 1}");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dlgResult = openFileDialog1.ShowDialog(this);
            if (dlgResult == DialogResult.Cancel)
                return;
            txtFilePath.Text = openFileDialog1.FileName;
            Factory.UpdateDataSourcePath(openFileDialog1.FileName);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (dgvCSVData.SelectedCells.Count == 0)
                return;
            if (txtOldChar.Text.Length != 1 || txtNewChar.Text.Length != 1)
            {
                MessageBox.Show("Please enter a character to replace in the proper fields", "Invalid Input", MessageBoxButtons.OK);
                return;
            }
            char oldChar = txtOldChar.Text.Length == 1 ? txtOldChar.Text[0] : 'a';
            char newChar = txtNewChar.Text.Length == 1 ? txtNewChar.Text[0] : '@';
            string currentVal = dgvCSVData.SelectedCells[0].Value.ToString() ?? "";
            dgvCSVData.SelectedCells[0].Value = currentVal.Replace(oldChar, newChar);

        }

        private void btnShowID_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected ID {cbxKeyValue.SelectedValue.ToString()}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvCSVData.DataSource;
            List<IEnumerable<string>> list = new List<IEnumerable<string>>();
            //.... saving the column headers.................................
            List<string> colNames = new List<string>();
            foreach (DataColumn col in dt.Columns)
            {
                colNames.Add(col.ColumnName);
            }
            list.Add(colNames);
            //................................................................
            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> converted = row.ItemArray.Select(x => x.ToString() ?? "").ToArray<string>();
                list.Add(converted);
            }
            var dlgresult = saveFileDialog1.ShowDialog();
            if (dlgresult == DialogResult.OK)
            {
                bool isSaved = _dataAccessSource.SaveData(list, saveFileDialog1.FileName);
                if (isSaved)
                    MessageBox.Show("File was saved successfully");
                else
                    MessageBox.Show("Error! Couldn't save the file");
            }
        }
    }
}
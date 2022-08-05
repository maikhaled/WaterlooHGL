using System.Data;

namespace Challenge_MaiAhmed
{
    public partial class FrmMain : Form
    {
        IDataAccess _dataAccessSource = null;
        public FrmMain()
        {
            InitializeComponent();
            _dataAccessSource = Factory.CreateDataAccessObj();
            //............................................................
            textBox1.Text = Factory.GetDataSourcePath();
            var dataArray = _dataAccessSource.LoadKeyValueData().Select(x=> new { Key=x.Key, Value=x.Value }).OrderBy(x=>x.Value).ToArray();
            cbxKeyValue.DataSource = dataArray;
            cbxKeyValue.ValueMember = "Key";
            cbxKeyValue.DisplayMember = "Value";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {            
            var myData = _dataAccessSource.LoadData();
            if (myData.Datarows.Count == 0)
                return;
            DataTable dt = new DataTable();
            for (int i = 0; i < myData.Datarows[0].DataItems.Count; i++)
            {
                if (Factory.ColumnNamesExistsInFile)
                    dt.Columns.Add(myData.ColumnTitles[i]);
                else
                    dt.Columns.Add($"Column {i+1}");
            }
            foreach (var item in myData.Datarows)
            {
              var dr = dt.NewRow();
                dr.ItemArray = item.DataItems.ToArray();
                dt.Rows.Add(dr);
            }
            dgvCSVData.DataSource = dt;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dlgResult = openFileDialog1.ShowDialog(this);
            if (dlgResult == DialogResult.Cancel)
                return;
            textBox1.Text = openFileDialog1.FileName;
            Factory.UpdateDataSourcePath(openFileDialog1.FileName);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (dgvCSVData.SelectedCells.Count == 0)
                return;
            if(txtOldChar.Text.Length != 1 || txtNewChar.Text.Length !=1)
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
    }
}
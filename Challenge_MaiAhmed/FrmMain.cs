using System.Data;

namespace Challenge_MaiAhmed
{
    public partial class FrmMain : Form
    {
       
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var DA = Factory.CreateDataAccessObj();
            var myData = DA.LoadData();
            if (myData.Datarows.Count == 0)
                return;
            DataTable dt = new DataTable();
            for (int i = 0; i < myData.ColumnTitles.Count; i++)
            {
                dt.Columns.Add(myData.ColumnTitles[i]);
            }
            foreach (var item in myData.Datarows)
            {
              var dr = dt.NewRow();
                dr.ItemArray = item.DataItems.ToArray();
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
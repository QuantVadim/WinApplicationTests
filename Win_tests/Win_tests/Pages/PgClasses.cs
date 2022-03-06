using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.Wins;

namespace Win_tests.Pages
{
    public partial class PgClasses : UserControl
    {
        string usr_id = Program.user.usr_id.ToString();
        List<DataRow> list;

        public PgClasses()
        {
            InitializeComponent();
        }

        private void PgClasses_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public void LoadInfo() {
            string sql = "SELECT * from classes order by cls_id desc";

            DataSet dt = DB.Query(sql);

            DataTable dtable = dt.Tables[0];
            list = new List<DataRow>(0);

            dataGrid.DataSource = dtable;
            dataGrid.Columns["cls_id"].HeaderText = "Код";
            dataGrid.Columns["name"].HeaderText = "Название";
            dataGrid.Columns["description"].HeaderText = "Описание";
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                string cls_id = dataGrid.Rows[e.RowIndex].Cells["cls_id"].Value.ToString();
                WinClass wcls = new WinClass(Convert.ToInt32(cls_id));
                wcls.OnChange += LoadInfo;
                wcls.Show();
            }
        }

        private void addClass_Click(object sender, EventArgs e)
        {
            WinClass wcls = new WinClass();
            wcls.OnChange += LoadInfo;
            wcls.Show();
        }
    }
}

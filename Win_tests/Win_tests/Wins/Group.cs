using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.UserControls;

namespace Win_tests.Wins
{
    public partial class Group : Form
    {
        int gr_id = 0;
        DataRow data;
        DataRowCollection tests;


        public Group(int gr_id)
        {
            InitializeComponent();
            this.gr_id = gr_id;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Group_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData() {
            string sql = "SELECT groups.*, users.name as \"teacher_name\", users.last_name as \"teacher_last_name\", " +
                " classes.name as \"class_name\" from groups " +
                " left join users on users.usr_id = groups.usr_id " +
                " left join classes on classes.cls_id = groups.cls_id " +
                " where gr_id = " + gr_id + " limit 1";
            DataSet dt = DB.Query(sql);
            if (dt.Tables[0].Rows.Count == 1)
            {
                data = dt.Tables[0].Rows[0];
                groupName.Text = data["name"].ToString();
                teacher.Text = "Учитель: " + data["teacher_name"].ToString() + " " + data["teacher_last_name"].ToString();
                countUsers.Text = "Класс: " + data["class_name"];
            }

            sql = "SELECT wall.*, tests.name, tests.tst_id, tests.description \"test_description\" from wall " +
                " left join tests using(tst_id) " +
                " where gr_id = " + gr_id + " order by gr_id desc";
            DataSet dtl = DB.Query(sql);
            content.Controls.Clear();
            if (dtl.Tables[0].Rows.Count > 0)
            {
                dtl.Tables[0].Columns.Add("usr_id");
                tests = dtl.Tables[0].Rows;
                for (int i = 0; i < tests.Count; i++)
                {
                    tests[i]["usr_id"] = data["usr_id"];
                    LiGTest lgt = new LiGTest(tests[i]);
                    lgt.OnChange += LoadData;
                    content.Controls.Add(lgt);
                }
            }
        }

    }
}

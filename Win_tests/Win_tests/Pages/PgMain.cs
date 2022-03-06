using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.UserControls;

namespace Win_tests.Pages
{
    public partial class PgMain : UserControl
    {
        public PgMain()
        {
            InitializeComponent();
        }

        private void PgMain_Load(object sender, EventArgs e)
        {
            string usr_id = Program.user.usr_id.ToString();

            string sql = "SELECT groups.gr_id, wall.wl_id, wall.date_created, groups.name as \"group_name\"," +
                " concat(concat(te.name, ' '), te.last_name) as \"full_name\"," +
                " wall.description as \"wall_description\"," +
                " tests.name as \"test_name\"," +
                " tests.description as \"test_description\" " +
                " from wall " +
                " left join groups on groups.gr_id = wall.gr_id " +
                " left join classes on classes.cls_id = groups.cls_id " +
                " left join users on users.cls_id = groups.cls_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join users as \"te\" on te.usr_id = groups.usr_id " +
                " where users.usr_id = " + usr_id+ " order by wall.wl_id desc";

            DataSet dt = DB.Query(sql);
            content.Controls.Clear();
            if (dt.Tables[0].Rows.Count > 0) {
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++) {
                    LiHomeTest lht = new LiHomeTest(dt.Tables[0].Rows[i]);
                    content.Controls.Add(lht);
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.UserControls;
using Win_tests.Wins;

namespace Win_tests.Pages
{
    public partial class PgTests : UserControl
    {
        DataSet data;
        public PgTests()
        {
            InitializeComponent();
        }

        private void PgTests_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public void LoadInfo() {
            string usr_id = Program.user.usr_id.ToString();
            string sql = "SELECT tests.*," +
                " concat(concat(users.name, ' '), users.last_name) as \"autor_name\" " +
                " from tests " +
                " left join users using(usr_id) " +
                " where usr_id = " + usr_id+" order by tst_id desc";
            if (Program.user.usr_type == "admin") {
                sql = "SELECT tests.*," +
                " concat(concat(users.name, ' '), users.last_name) as \"autor_name\" " +
                " from tests " +
                " left join users using(usr_id) " +
                " order by tst_id desc";
            }
            data = DB.Query(sql);
            UpdateList();
        }
        public void FindInfo()
        {
            string text = tb_finder.Text.Trim();
            if (text.Length == 0) {
                LoadInfo();
                return;
            }
            string usr_id = Program.user.usr_id.ToString();
            string sql = "SELECT tests.*," +
                " concat(concat(users.name, ' '), users.last_name) as \"autor_name\" " +
                " from tests " +
                " left join users using(usr_id) " +
                " where usr_id = " + usr_id + " AND " +
                " lower(tests.name) LIKE lower('%" + text+"%') " +
                " order by tst_id desc";
            if (Program.user.usr_type == "admin")
            {
                sql = "SELECT tests.*," +
                " concat(concat(users.name, ' '), users.last_name) as \"autor_name\" " +
                " from tests " +
                " left join users using(usr_id) where " +
                " ( lower(tests.name) LIKE lower('%" + text + "%') OR " +
                " lower(concat(concat(users.name, ' '), users.last_name)) LIKE lower('%" + text+"%') ) " +
                " order by tst_id desc";
            }
            data = DB.Query(sql);
            UpdateList();
        }

        public void UpdateList() {
            content.Controls.Clear();
            if (data.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    LiTest lg = new LiTest(data.Tables[0].Rows[i]);
                    lg.onDelete += DeleteTest;
                    lg.OnChange += FindInfo;
                    content.Controls.Add(lg);
                }
            }
        }


        private void DeleteTest(int tst_id)
        {
            if (DB.Modification_Execute("DELETE from tests where tst_id = " + tst_id.ToString())) {
                for(int i = 0; i < content.Controls.Count; i++)
                {
                    LiTest lt = ((LiTest)content.Controls[i]);
                    if (Convert.ToInt32(lt.data["tst_id"]) == tst_id) {
                        content.Controls.RemoveAt(i);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void addTest_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.OnChange += FindInfo;
            test.Show();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            FindInfo();
        }

        private void tb_finder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                FindInfo();
            }
        }
    }
}

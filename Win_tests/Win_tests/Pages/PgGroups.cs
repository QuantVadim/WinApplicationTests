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
    public partial class PgGroups : UserControl
    {
        public PgGroups()
        {
            InitializeComponent();
        }


        private void PgGroups_Load(object sender, EventArgs e)
        {
            LoadData();
            if (Program.user.usr_type != "admin") {
                addGroup.Visible = false;
                addGroup.Enabled = false;
            }
        }
        public void LoadData() {
            DataSet dt;
            string sql = "";
            string usr_id = Program.user.usr_id.ToString();
            switch (Program.user.usr_type)
            {
                case "admin":
                    sql = "SELECT groups.*, teacher.name as \"teacher_name\", " +
                        " teacher.last_name as \"teacher_last_name\", " +
                        " classes.name as \"class_name\" " +
                        " FROM groups  " +
                        " left join users \"teacher\" on teacher.usr_id = groups.usr_id " +
                        " left join classes on groups.cls_id = classes.cls_id " +
                        "order by gr_id desc";
                    break;
                case "teacher":
                    
                    sql = "SELECT groups.*, teacher.name as \"teacher_name\", " +
                        " classes.name as \"class_name\", " +
                        " teacher.last_name as \"teacher_last_name\" FROM groups " +
                        " left join users \"teacher\" on teacher.usr_id = groups.usr_id " +
                        " left join classes on groups.cls_id = classes.cls_id " +
                        "where groups.usr_id = '" + usr_id+"' order by gr_id desc";
                    break;
                case "student":
                    sql = "Select groups.*, teacher.name as \"teacher_name\", " +
                        " classes.name as \"class_name\", " +
                        " teacher.last_name as \"teacher_last_name\" from groups " +
                          "left join users on groups.cls_id = users.cls_id " +
                          "left join users \"teacher\" on teacher.usr_id = groups.usr_id " +
                          " left join classes on groups.cls_id = classes.cls_id " +
                          "where users.usr_id = "+ usr_id + " order by gr_id desc; ";
                    break;
                default:
                    break;
            }
            content.Controls.Clear();
            if (sql.Length > 0) {
                dt = DB.Query(sql);
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    Li_Group lg = new Li_Group(dt.Tables[0].Rows[i]);
                    lg.onChange += LoadData;
                    content.Controls.Add(lg);
                }
            }
        }
        public void FindInfo()
        {
            string text = tb_finder.Text.Trim();
            if (text.Length == 0)
            {
                LoadData();
                return;
            }

            DataSet dt;
            string sql = "";
            string usr_id = Program.user.usr_id.ToString();
            switch (Program.user.usr_type)
            {
                case "admin":
                    sql = "SELECT groups.*, teacher.name as \"teacher_name\", " +
                        " teacher.last_name as \"teacher_last_name\", " +
                        " classes.name as \"class_name\" " +
                        " FROM groups  " +
                        " left join users \"teacher\" on teacher.usr_id = groups.usr_id " +
                        " left join classes on groups.cls_id = classes.cls_id " +
                        " where lower(groups.name) LIKE lower('%" + text+"%') OR " +
                        " lower(concat(concat(teacher.name, ' '), teacher.last_name)) LIKE lower('%" + text + "%') OR " +
                        " lower(groups.description) LIKE lower('%" + text + "%') OR " +
                        " lower(classes.name) LIKE lower('%" + text + "%') " +
                        " order by gr_id desc";
                    break;
                case "teacher":
                    sql = "SELECT groups.*, teacher.name as \"teacher_name\", " +
                        " classes.name as \"class_name\", " +
                        " teacher.last_name as \"teacher_last_name\" FROM groups " +
                        " left join users \"teacher\" on teacher.usr_id = groups.usr_id " +
                        " left join classes on groups.cls_id = classes.cls_id " +
                        " where groups.usr_id = '" + usr_id + "' AND " +
                        " ( lower(groups.name) LIKE lower('%" + text + "%') OR " +
                        " lower(classes.name) LIKE lower('%" + text + "%') " +
                        " ) order by gr_id desc";
                    break;
                case "student":
                    sql = "Select groups.*, teacher.name as \"teacher_name\", " +
                        " classes.name as \"class_name\", " +
                        " teacher.last_name as \"teacher_last_name\" from groups " +
                        " left join users on groups.cls_id = users.cls_id " +
                        " left join users \"teacher\" on teacher.usr_id = groups.usr_id " +
                        " left join classes on groups.cls_id = classes.cls_id " +
                        " where users.usr_id = " + usr_id + " AND" +
                        " lower(groups.name) LIKE lower('%" + text + "%') " +
                        " order by gr_id desc; ";
                    break;
                default:
                    break;
            }
            content.Controls.Clear();
            if (sql.Length > 0)
            {
                dt = DB.Query(sql);
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    Li_Group lg = new Li_Group(dt.Tables[0].Rows[i]);
                    lg.onChange += FindInfo;
                    content.Controls.Add(lg);
                }
            }
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            EditorGroup edgr = new EditorGroup();
            edgr.OnChange += FindInfo;
            edgr.Show();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            FindInfo();
        }

        private void tb_finder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindInfo();
            }
        }
    }
}

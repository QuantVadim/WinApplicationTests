using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Win_tests.Wins
{
    public partial class EditorGroup : Form
    {
        DataTable classes;
        DataTable users;
        DataRow group;

        public delegate void deleg();
        public event deleg OnChange;
        public EditorGroup()
        {
            InitializeComponent();
            label_code.Text = "Новая";
            btn_save.Text = "Создать";
            LoadClasses();
            LoadUsers();
        }

        public EditorGroup(int gr_id)
        {
            InitializeComponent();
            label_code.Text = "Код: " + gr_id.ToString();
            LoadClasses();
            LoadUsers();
            DataSet dt = DB.Query("SELECT * FROM groups where gr_id = " + gr_id+" limit 1");
            if (dt.Tables[0].Rows.Count == 1) {
                group = dt.Tables[0].Rows[0];
                UpdateData();
            }

        }

        public void UpdateData() {
            tb_name.Text = group["name"].ToString();
            tb_description.Text = group["description"].ToString();
            SelectClass(Convert.ToInt32(group["cls_id"]));
            SelectUser(Convert.ToInt32(group["usr_id"]));
        }

        public void SelectClass(int cls_id)
        {
            if (classes.Rows.Count > 0)
            {
                for (int i = 0; i < classes.Rows.Count; i++)
                {
                    if (classes.Rows[i]["cls_id"].ToString() == cls_id.ToString())
                    {
                        tb_class.SelectedIndex = i;
                        break;
                    }
                }
            }
            if (group["usr_id"].ToString() == Program.user.usr_id.ToString()
                && Program.user.usr_type != "admin") {
                tb_class.Enabled = false;
                tb_user.Enabled = false;
            }
        }
        public void SelectUser(int usr_id)
        {
            if (users.Rows.Count > 0)
            {
                for (int i = 0; i < users.Rows.Count; i++)
                {
                    if (users.Rows[i]["usr_id"].ToString() == usr_id.ToString())
                    {
                        tb_user.SelectedIndex = i;
                        break;
                    }
                }
            }
        }


        public void LoadClasses()
        {
            string sql = "SELECT * from classes order by cls_id desc";
            DataSet dt = DB.Query(sql);
            if (dt.Tables[0].Rows.Count > 0)
            {
                classes = dt.Tables[0];
                tb_class.Items.Clear();
                for (int i = 0; i < classes.Rows.Count; i++)
                {
                    string label = "[" + classes.Rows[i]["cls_id"].ToString() + "] " +
                        classes.Rows[i]["name"].ToString();
                    tb_class.Items.Add(label);
                }
            }
        }

        public void LoadUsers()
        {
            string sql = "SELECT * from users where usr_type = 'teacher' or usr_type = 'admin' order by usr_id desc";
            DataSet dt = DB.Query(sql);
            if (dt.Tables[0].Rows.Count > 0)
            {
                users = dt.Tables[0];
                tb_user.Items.Clear();
                for (int i = 0; i < users.Rows.Count; i++)
                {
                    string label = "[" + users.Rows[i]["usr_id"].ToString() + "] " +
                        users.Rows[i]["name"].ToString()+" "+ users.Rows[i]["last_name"].ToString();
                    tb_user.Items.Add(label);
                }
            }
        }

        private void EditorGroup_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_class.SelectedIndex < 0 || tb_user.SelectedIndex < 0
                || tb_name.Text.Trim().Length == 0 ) {
                MessageBox.Show("Некоторые поля некорректно заполнены", "Ошибка");
                return;
            }
            
            string sql;
            string types;
            Dictionary<string, object> list = new Dictionary<string, object>(0);

            if (group != null)
            {
                sql = "UPDATE groups set name = @name, description = @description, " +
                    " usr_id = @usr_id, cls_id = @cls_id where gr_id = @gr_id";
                types = "issii";
                list.Add("gr_id", Convert.ToInt32(group["gr_id"]));
            }
            else {
                sql = "INSERT INTO groups (name, description, usr_id, cls_id) VALUES " +
                    " (@name, @description, @usr_id, @cls_id) ";
                types = "ssii";
            }
            list.Add("name", tb_name.Text.Trim());
            list.Add("description", tb_description.Text.Trim());
            list.Add("usr_id", users.Rows[tb_user.SelectedIndex]["usr_id"]);
            list.Add("cls_id", classes.Rows[tb_class.SelectedIndex]["cls_id"]);

            if (DB.PrepareMod(sql, types, list))
            {
                if (OnChange != null) OnChange.Invoke();
                this.Close();
            }
            else {
                MessageBox.Show("Ошибка обновления данных", "Ошибка");
            }
        }
    }
}

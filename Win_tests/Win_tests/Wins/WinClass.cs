using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Win_tests.Wins
{
    public partial class WinClass : Form
    {
        DataRow data;
        DataRowCollection users;

        public delegate void deleg();
        public event deleg OnChange;
        public WinClass()
        {
            InitializeComponent();
            class_code.Text = "Новый";
            btn_save.Text = "Создать";
            btn_delete.Visible = false;
            btn_delete.Enabled = false;
        }

        public WinClass(int cls_id)
        {
            InitializeComponent();

            string sql = "SELECT * from classes where cls_id = "+cls_id.ToString()+" limit 1";
            DataSet dt = DB.Query(sql);
            if (dt.Tables[0].Rows.Count == 1) {
                data = dt.Tables[0].Rows[0];
                tb_name.Text = data["name"].ToString();
                tb_description.Text = data["description"].ToString();
                LoadUsers();
            }
            class_code.Text = "Код: " + cls_id;
        }

        public void LoadUsers() {
            if (data != null) {
                string cls_id = data["cls_id"].ToString();
                string sql = "SELECT * from users where cls_id = " + cls_id;
                DataSet dt = DB.Query(sql);
                if (dt.Tables[0].Rows.Count > 0) {
                    list_users.Items.Clear();
                    users = dt.Tables[0].Rows;
                    for (int i = 0; i < users.Count; i++) {
                        string li_label = "["+users[i]["usr_id"].ToString()+"] "+ users[i]["name"].ToString() + " " + 
                            users[i]["last_name"].ToString();
                        list_users.Items.Add(li_label);
                        label_users_count.Text = "Состав класса (" + users.Count + "):";
                    }
                }
            }
        }

        private void WinClass_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Trim().Length > 0)
            {
                Dictionary<string, object> list = new Dictionary<string, object>(0);
                string sql = "", types;
                list.Add("name", tb_name.Text.Trim());
                list.Add("description", tb_description.Text.Trim());
                if (data != null)
                {
                    sql = "UPDATE classes set name = @name, description = @description " +
                        " where cls_id = @cls_id ";
                    list.Add("cls_id", data["cls_id"]);
                    types = "ssi";
                }
                else
                {
                    sql = "INSERT INTO classes (name, description) VALUES" +
                        " (@name, @description)";
                    types = "ss";
                }
                if (DB.PrepareMod(sql, types, list))
                {
                    if (OnChange != null) OnChange.Invoke();
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Введите название класса!", "Ошибка");
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Вы уверены, что хотите удалить этот класс?",
                "Подтверждение", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes) {
                if (data != null)
                {
                    string cls_id = data["cls_id"].ToString();
                    if (DB.Modification_Execute("DELETE FROM classes where cls_id = " + cls_id))
                    {
                        if (OnChange != null) OnChange.Invoke();
                        this.Close();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Win_tests.Wins
{
    public partial class WinUser : Form
    {
        DataRow user;
        DataTable classes;

        public delegate void deleg();
        public event deleg onChange;
        public WinUser()
        {
            InitializeComponent();

            LoadClasses();
            user_code.Text = "Новый";
            btn_save.Text = "Создать";
            tb_user_type.Text = "student";
            btn_delete.Visible = false;
            btn_delete.Enabled = false;
        }

        public WinUser(int usr_id)
        {
            InitializeComponent();

            LoadClasses();
            string sql = "SELECT * from users " +
                " where usr_id = " + usr_id+" limit 1";
            DataSet dt = DB.Query(sql);
            if (dt.Tables[0].Rows.Count == 1) {
                user = dt.Tables[0].Rows[0];
                tb_name.Text = user["name"].ToString();
                tb_last_name.Text = user["last_name"].ToString();
                tb_login.Text = user["login"].ToString();
                tb_password.Text = user["password"].ToString();
                SelectClass(Convert.ToInt32(user["cls_id"]));
                tb_user_type.Text = user["usr_type"].ToString();
            }
            user_code.Text = "Код: "+ usr_id;

        }

        public void SelectClass(int cls_id) {
            if (classes.Rows.Count > 0) {
                for (int i = 0; i < classes.Rows.Count; i++) {
                    if (classes.Rows[i]["cls_id"].ToString() == cls_id.ToString()) {
                        tb_class.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        public void LoadClasses() {
            string sql = "SELECT * from classes order by cls_id desc";
            DataSet dt = DB.Query(sql);
            if (dt.Tables[0].Rows.Count > 0) {
                classes = dt.Tables[0];
                tb_class.Items.Clear();
                for (int i = 0; i < classes.Rows.Count; i++) {
                    string label = "[" + classes.Rows[i]["cls_id"].ToString() + "] " +
                        classes.Rows[i]["name"].ToString();
                    tb_class.Items.Add(label);
                }
            }
        }

        private void WinUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_class.SelectedIndex < 0 || tb_name.Text.Trim().Length == 0 ||
                tb_last_name.Text.Trim().Length == 0 ||
                tb_login.Text.Trim().Length == 0 ||
                tb_password.Text.Trim().Length == 0 || 
                tb_class.SelectedIndex < 0 ||
                tb_user_type.SelectedIndex < 0
                ) {
                MessageBox.Show("Некоторые поля некорректно заполнены", "Ошибка");
                return;
            }
            string sql;
            Dictionary<string, object> list = new Dictionary<string, object>(0);
            string types;
            list.Add("name", tb_name.Text.ToString().Trim());
            list.Add("last_name", tb_last_name.Text.ToString().Trim());
            list.Add("usr_type", tb_user_type.Text.ToString().Trim());
            list.Add("cls_id", Convert.ToInt32(classes.Rows[tb_class.SelectedIndex]["cls_id"]));
            list.Add("login", tb_login.Text.ToString().Trim());
            list.Add("password", tb_password.Text.ToString().Trim());
            if (user != null)
            {
                sql = "UPDATE users set name = @name, last_name = @last_name, usr_type = @usr_type, " +
                    " cls_id = @cls_id, login = @login, password = @password where usr_id = @usr_id";
                list.Add("usr_id", Convert.ToInt32(user["usr_id"].ToString()));
                types = "sssissi";
            }
            else {
                sql = "INSERT INTO users (name, last_name, usr_type, cls_id, login, password) " +
                   " VALUES (@name, @last_name, @usr_type, @cls_id, @login, @password) ";
                types = "sssiss";
            }
            
            if (DB.PrepareMod(sql, types, list) )
            {
                if (onChange != null) onChange();
                this.Close();
            }
            else {
                MessageBox.Show("Ошибка обновления данных!", "Ошибка");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string msg = "Вы уверены, что хотите удалить пользователя "+user["name"].ToString()+
                " "+user["last_name"].ToString()+"?";
            DialogResult dia = MessageBox.Show(msg, "Подтверждение действия", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes) {
                string sql = "DELETE FROM users where usr_id = " + user["usr_id"].ToString();
                DB.Modification_Execute(sql);
                if (onChange != null) onChange();
                this.Close();
            }
        }
    }
}

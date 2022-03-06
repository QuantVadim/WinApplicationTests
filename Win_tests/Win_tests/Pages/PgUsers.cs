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
    public partial class PgUsers : UserControl
    {
        
        public PgUsers()
        {
            InitializeComponent();
        }

        private void PgUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public void LoadUsers() {
            string sql = "SELECT users.*, classes.name as \"class_name\" " +
                    " from users " +
                    " left join classes on users.cls_id = classes.cls_id";
            DataSet dt = DB.Query(sql);

            DataTable dtable = dt.Tables[0];

            dtable.Columns.Remove("cls_id");
            dataGrid.DataSource = dtable;

            dataGrid.Columns["usr_id"].HeaderText = "Код";
            dataGrid.Columns["name"].HeaderText = "Имя";
            dataGrid.Columns["last_name"].HeaderText = "Фамилия";
            dataGrid.Columns["class_name"].HeaderText = "Класс";
            dataGrid.Columns["login"].HeaderText = "Логин";
            dataGrid.Columns["password"].HeaderText = "Пароль";
        }

        public void FindUsers(string text) {
          
            if (text.Length > 0)
            {
                string sql = "SELECT users.*, classes.name as \"class_name\" " +
                    " from users " +
                    " left join classes on users.cls_id = classes.cls_id" +
                    " where lower(users.name) Like lower('%" + text+"%') " +
                    " or lower(users.last_name) Like lower('%" + text + "%') " +
                    " or lower(classes.name) Like lower('%" + text + "%') " +
                    " or lower(users.usr_type) Like lower('%" + text + "%') " +
                    " or lower(users.login) Like lower('%" + text + "%') ";
                DataSet dt = DB.Query(sql);

                DataTable dtable = dt.Tables[0];

                dtable.Columns.Remove("cls_id");
                dataGrid.DataSource = dtable;

                dataGrid.Columns["usr_id"].HeaderText = "Код";
                dataGrid.Columns["name"].HeaderText = "Имя";
                dataGrid.Columns["last_name"].HeaderText = "Фамилия";
                dataGrid.Columns["class_name"].HeaderText = "Класс";
                dataGrid.Columns["login"].HeaderText = "Логин";
                dataGrid.Columns["password"].HeaderText = "Пароль";
            }
            else
            {
                LoadUsers();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string text = tb_Search.Text.Trim();
            FindUsers(text);
        }

        private void tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) FindUsers(tb_Search.Text.Trim());
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int usr_id = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["usr_id"].Value);
                 WinUser winUser = new WinUser(usr_id);
                winUser.onChange += delegate ()
                { FindUsers(tb_Search.Text.Trim()); };
                winUser.Show();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            WinUser winUser = new WinUser();
            winUser.onChange += delegate () 
            { FindUsers(tb_Search.Text.Trim()); };
            winUser.Show();
        }
    }
}

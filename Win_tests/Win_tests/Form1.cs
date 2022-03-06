using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_tests.Classes;

namespace Win_tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoEnter();
        }

        public void DoEnter() {
            DataSet dt =
            DB.Query("SELECT * from users where login = '" + login.Text + "' and password = '" + password.Text + "' limit 1");
            //DB.Query("SELECT * from users where usr_id = '" + password.Text + "' limit 1");
            if (dt.Tables[0].Rows.Count == 1)
            {
                Program.user = new User(dt.Tables[0].Rows[0]);
                Program.mainForm = new MainForm();
                Program.mainForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Ошибка авторизации", "Неверное имя пользователя или пароль");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) password.Focus();
            if (e.KeyCode == Keys.Down) password.Focus();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) DoEnter();
            if (e.KeyCode == Keys.Up) login.Focus();
        }
    }
}

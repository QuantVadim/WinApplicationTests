using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.Pages;

namespace Win_tests
{
    public partial class MainForm : Form
    {
        PgGroups pgGroups;
        PgTests pgTests;
        PgResults pgResults;
        PgMain pgMain;

        public string usr_type = "default";
        public MainForm()
        {
            InitializeComponent();
            NavigatorUpdate();
        }

        public void NavigatorUpdate() {
            switch (Program.user.usr_type) {
                case "student":
                    Navbar.Controls.Remove(Nav_Tests);
                    Navbar.Controls.Remove(Nav_Users);
                    Navbar.Controls.Remove(Nav_Classes);
                    break;
                case "teacher":
                    Navbar.Controls.Remove(Nav_Users);
                    Navbar.Controls.Remove(Nav_Classes);
                    break;
                case "admin":
                    Navbar.Controls.Remove(Nav_Home);
                    break;
                default:

                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string userFullName = Program.user.name + " " + Program.user.last_name;
            usr_type = Program.user.usr_type;
            user_name.Text = userFullName+ " (" + usr_type + ")";
            this.Text = "[" + userFullName + "] - Тестирование учащихся МБОУ СОШ №1";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageName.Text = "Группы";
            pgGroups = new PgGroups();
            content.Controls.Clear();
            content.Controls.Add(pgGroups);
            ContentSizeUpdate();
            navBtnFocus((Button)sender);
        }

        private void content_Resize(object sender, EventArgs e)
        {
            ContentSizeUpdate();
        }

        public void ContentSizeUpdate() {
            if (content.Controls.Count == 1)
            {
                content.Controls[0].Width = content.Width;
                content.Controls[0].Height = content.Height;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageName.Text = "Тесты";
            pgTests = new PgTests();
            content.Controls.Clear();
            content.Controls.Add(pgTests);
            ContentSizeUpdate();
            navBtnFocus((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageName.Text = "Главная";
            pgMain = new PgMain();
            content.Controls.Clear();
            content.Controls.Add(pgMain);
            ContentSizeUpdate();
            navBtnFocus((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageName.Text = "Решения";
            pgResults = new PgResults();
            content.Controls.Clear();
            content.Controls.Add(pgResults);
            ContentSizeUpdate();
            navBtnFocus((Button)sender);
        }

        private void Navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nav_Users_Click(object sender, EventArgs e)
        {
            PageName.Text = "Люди";
            PgUsers pgUsers = new PgUsers();
            content.Controls.Clear();
            content.Controls.Add(pgUsers);
            ContentSizeUpdate();
            navBtnFocus((Button)sender);
        }

        private void user_name_Click(object sender, EventArgs e)
        {
          
        }

        private void Nav_Classes_Click(object sender, EventArgs e)
        {
            PageName.Text = "Классы";
            PgClasses pgClasses = new PgClasses();
            content.Controls.Clear();
            content.Controls.Add(pgClasses);
            ContentSizeUpdate();
            navBtnFocus((Button)sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        public void navBtnFocus(Button btn) {
            for (int i = 0; i < Navbar.Controls.Count; i++) {
                Button cbt = (Button)(Navbar.Controls[i]);
                cbt.BackColor = Color.FromArgb(64, 64, 64);
            }
            btn.BackColor = Color.FromArgb(100, 100, 100);
        }
    }
}

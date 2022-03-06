using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.Wins;

namespace Win_tests.UserControls
{
    public partial class LiHomeTest : UserControl
    {
        DataRow data;
        int wl_id;
        int gr_id;
        public LiHomeTest(DataRow data)
        {
            this.data = data;
            InitializeComponent();
        }

        private void LiHomeTest_Load(object sender, EventArgs e)
        {
            this.Parent.SizeChanged += ChangeWidth;
            this.Width = this.Parent.Width - 24;

            groupName.Text = data["group_name"].ToString();
            fullName.Text = data["full_name"].ToString();
            //wallDescription.Text = data["wall_description"].ToString();
            testName.Text = data["test_name"].ToString();
            testDescription.Text = data["test_description"].ToString();

            string date = data["date_created"].ToString();
            date = "[" + date.Remove(date.Length - 3) + "] ";
            date = date.Insert(12, "в ");
            wallDescription.Text = date + data["wall_description"].ToString();

            wl_id = Convert.ToInt32(data["wl_id"]);
            gr_id = Convert.ToInt32(data["gr_id"]);
        }

        private void ChangeWidth(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 24;
        }

        private void panelTest_Click(object sender, EventArgs e)
        {
            Testing testing = new Testing(wl_id);
            testing.Show();
        }

        private void panelGroup_Click(object sender, EventArgs e)
        {
            Group group = new Group(gr_id);
            group.Show();
        }

        private void panelGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTest_MouseClick(object sender, MouseEventArgs e)
        {
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Testing testing = new Testing(wl_id);
            testing.Show();
        }

        private void wallDescription_Click(object sender, EventArgs e)
        {
            Testing testing = new Testing(wl_id);
            testing.Show();
        }

        private void testName_Click(object sender, EventArgs e)
        {
            Testing testing = new Testing(wl_id);
            testing.Show();
        }

        private void testDescription_Click(object sender, EventArgs e)
        {
            Testing testing = new Testing(wl_id);
            testing.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Group group = new Group(gr_id);
            group.Show();
        }

        private void groupName_Click(object sender, EventArgs e)
        {
            Group group = new Group(gr_id);
            group.Show();
        }

        private void fullName_Click(object sender, EventArgs e)
        {
            Group group = new Group(gr_id);
            group.Show();
        }
    }
}

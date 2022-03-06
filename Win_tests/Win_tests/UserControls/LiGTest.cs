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
    public partial class LiGTest : UserControl
    {
        public DataRow data;

        public delegate void deleg();
        public event deleg OnChange;
        public LiGTest(DataRow data)
        {
            this.data = data;
            InitializeComponent();
        }

        private void LiGTest_Load(object sender, EventArgs e)
        {
            if (Program.user.usr_type != "admin") {
                btn_delete.Enabled = false;
                btn_delete.Visible = false;
            }
            if (Program.user.usr_id.ToString() == data["usr_id"].ToString()) {
                btn_delete.Enabled = true;
                btn_delete.Visible = true;
            }
            this.Parent.SizeChanged += ChangeWidth;
            this.Width = this.Parent.Width - 24;
            UpdateInfo();
        }

        private void ChangeWidth(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 24;
        }

        public void UpdateInfo() {
            string date = data["date_created"].ToString();
            date = "["+date.Remove(date.Length - 3)+"] ";
            date = date.Insert(12, "в ");
            description.Text = date + data["description"].ToString();
            name.Text = data["name"].ToString();
            testDescription.Text = data["test_description"].ToString();
        }

        private void LiGTest_Click(object sender, EventArgs e)
        {
            Testing ts = new Testing(Convert.ToInt32(data["wl_id"]));
            ts.Show();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            WallResults wr = new WallResults(Convert.ToInt32(data["wl_id"]));
            wr.Show();
        }

        private void name_Click(object sender, EventArgs e)
        {
            Testing ts = new Testing(Convert.ToInt32(data["wl_id"]));
            ts.Show();
        }

        private void testDescription_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string msg = "Вы уверены, что хотите удалить публикацию теста в группе?";
            DialogResult dia = MessageBox.Show(msg, "Подтверждение", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes) {
                string sql = "DELETE FROM wall where wl_id = " + data["wl_id"];
                DB.Modification_Execute(sql);
                if (OnChange != null) OnChange.Invoke();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Testing ts = new Testing(Convert.ToInt32(data["wl_id"]));
            ts.Show();
        }
    }
}

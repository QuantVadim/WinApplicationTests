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
    public partial class LiTest : UserControl
    {
        public DataRow data;
        public delegate void ev(int tst_id);
        public event ev onDelete;
        public delegate void deleg();
        public event deleg OnChange;
        public LiTest(DataRow data)
        {
            InitializeComponent();
            this.data = data;
        }
        public void UpdateInfo() {
            label1.Text = data["name"].ToString();
            label2.Text = "Автор: " + data["autor_name"].ToString();
        }

        private void LiTest_Load(object sender, EventArgs e)
        {
            UpdateInfo();
            this.Parent.SizeChanged += WidthUpdate;
            this.Width = this.Parent.Width - 24;
        }
        public void WidthUpdate(object sender, EventArgs ev) {
            if (this.Parent != null) {
                this.Width = this.Parent.Width - 24;
            }
        }

        private void LiTest_Click(object sender, EventArgs e)
        {
            Test test = new Test(Convert.ToInt32(data["tst_id"]));
            test.OnChange += delegate() { if (OnChange != null) OnChange.Invoke(); };
            test.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (onDelete != null) {
                DialogResult dia = MessageBox.Show("Вы увернеы, что хотите удалить тест?", "Удаление теста", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes) {
                    onDelete(Convert.ToInt32(data["tst_id"]));
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendTest st = new SendTest(Convert.ToInt32(data["tst_id"]));
            st.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Test test = new Test(Convert.ToInt32(data["tst_id"]));
            test.OnChange += delegate () { if (OnChange != null) OnChange.Invoke(); };
            test.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Test test = new Test(Convert.ToInt32(data["tst_id"]));
            test.OnChange += delegate () { if (OnChange != null) OnChange.Invoke(); };
            test.Show();
        }
    }
}

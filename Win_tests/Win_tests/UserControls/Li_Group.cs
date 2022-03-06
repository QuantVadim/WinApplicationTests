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
    public partial class Li_Group : UserControl
    {
        DataRow dt;

        public delegate void deleg();
        public event deleg onChange;

        public Li_Group(DataRow dt)
        {
            InitializeComponent();
            this.dt = dt;
            label1.Text = dt["name"].ToString();
            label2.Text = "Учитель: "+dt["teacher_name"].ToString() + " " + dt["teacher_last_name"].ToString();
            label3.Text = "Класс: " + dt["class_name"].ToString();

            if (Program.user.usr_type != "admin") {
                btn_delete.Visible = false;
                btn_delete.Enabled = false;
                btn_edit.Visible = false;
                btn_edit.Enabled = false;
            }
            if (Program.user.usr_type == "teacher" && 
                dt["usr_id"].ToString() == Program.user.usr_id.ToString()) {
                btn_edit.Visible = true;
                btn_edit.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Group group = new Group(Convert.ToInt32(dt["gr_id"]));
            group.Show();
        }

        private void li_Group_Load(object sender, EventArgs e)
        {
            this.Parent.Resize += OnResize;
            this.Width = this.Parent.Width - 24;
        }

        private void OnResize(object obj, EventArgs ev)
        {
            this.Width = ((Control)obj).Width-24;
        }

        private void li_Group_Click(object sender, EventArgs e)
        {
            Group group = new Group(Convert.ToInt32(dt["gr_id"]));
            group.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditorGroup egr = new EditorGroup(Convert.ToInt32(dt["gr_id"]));
            egr.OnChange += delegate() { if (onChange != null) onChange.Invoke(); };
            egr.Show();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string txt = "Вы уверены, что хотите удалить тест " + dt["name"].ToString()+"?";
            DialogResult dia = MessageBox.Show(txt, "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes) {
                string sql = "DELETE FROM groups where gr_id = "+dt["gr_id"].ToString();
                if (DB.Modification_Execute(sql)) {
                    if (onChange != null) { onChange(); }
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Group group = new Group(Convert.ToInt32(dt["gr_id"]));
            group.Show();
        }
    }
}

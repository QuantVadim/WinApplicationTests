using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.Classes;

namespace Win_tests.UserControls
{
    public partial class LiTQuestion : UserControl
    {
        public Question question;
        public LiTQuestion(Question quest)
        {
            question = quest;
            InitializeComponent();
        }

        private void LiTQuestion_Load(object sender, EventArgs e)
        {
            lb_text.Text = question.text;
            this.Parent.SizeChanged += ChangeWidth;
            this.Width = this.Parent.Width - 24;
            this.Height = 72;
        }

        private void ChangeWidth(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 24;
        }

        public string GetAnswer() {
            return tb_answer.Text.Trim();
        }
    }
}

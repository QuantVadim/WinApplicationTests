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
    public partial class LiRQuestion : UserControl
    {
        public Question question;
        public LiRQuestion(Question quest)
        {
            question = quest;
            InitializeComponent();
        }

        private void LiRQuestion_Load(object sender, EventArgs e)
        {
            this.Parent.SizeChanged += ChangeWidth;
            this.Width = this.Parent.Width - 24;
            text.Text = question.text;
            answer.Text = question.answer;
            score.Text = question.score.ToString();
            if (question.score < 1)
            {
                answer.BackColor = Color.FromArgb(255, 192, 192);
            }
            else {
                answer.BackColor = Color.FromArgb(192, 255, 192);
            }
        }

        private void ChangeWidth(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 24;
        }
    }
}

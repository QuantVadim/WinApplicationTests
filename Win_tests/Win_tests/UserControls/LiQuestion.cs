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
    public partial class LiQuestion : UserControl
    {
        public Question question;
        public delegate void onev(int uid);
        public event onev onDelete;

        public LiQuestion( Question quest)
        {
            question = quest;
            InitializeComponent();
        }


        private void LiQuestion_Load(object sender, EventArgs e)
        {
            this.Parent.SizeChanged += WidthUpdate;
            this.Width = this.Parent.Width - 26;
            UpdateInfo();
        }

        private void WidthUpdate(object sender, EventArgs e)
        {
            this.Width = ((Control)sender).Width - 26;
        }

        public void UpdateInfo() {
            tb_text.Text = question.text;
            tb_answer.Text = question.answer;
            score.Value = question.score;
        }

        public Question GetQuestion() {
            question.text = tb_text.Text.Trim();
            question.answer = tb_answer.Text.Trim();
            question.score = Convert.ToInt32(score.Value);
            return question;
        }
        public void SetQuestion(Question quest) {
            question = quest;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            onDelete(question.qid);
        }
    }
}

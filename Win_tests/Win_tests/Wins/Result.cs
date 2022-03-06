using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Win_tests.Classes;
using Win_tests.UserControls;

namespace Win_tests.Wins
{
    public partial class Result : Form
    {
        string res_id;
        DataRow data;
        List<Question> list;
        public Result(int res_id)
        {
            this.res_id = res_id.ToString();
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            string sql = "SELECT results.*, tests.name, " +
                " concat(concat(users.name, ' '), users.last_name) as \"user_name\", " +
                " tests.score as \"max_score\" " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on wall.tst_id = tests.tst_id " +
                " left join users on users.usr_id = results.usr_id " +
                "where res_id = " + res_id + " limit 1";
            DataSet dt = DB.Query(sql);
            if (dt.Tables[0].Rows.Count == 1)
            {
                data = dt.Tables[0].Rows[0];
                UpdateInfo();
                UpdateBody();
            }
            else {
                MessageBox.Show("Результат не найден", "Ошибка");
                this.Close();
            }
        }

        public void UpdateInfo() {
            testName.Text = data["name"].ToString();
            float myscore = Convert.ToSingle(data["score"]);
            float maxscore = Convert.ToSingle(data["max_score"]);
            string scoreText = myscore.ToString() + " из " + maxscore.ToString();
            score.Text = scoreText;
            this.Text = "Решение - "+ data["user_name"].ToString();
            string procentScore = "--";
            if (maxscore > 0) {
                if (myscore >= maxscore)
                {
                    procentScore = "100%";
                }
                else {
                    procentScore = Math.Round((myscore / maxscore)*100).ToString() + "%";
                }
            }
            procent.Text = procentScore;
        }

        public void UpdateBody() {
            content.Controls.Clear();
            list = JsonSerializer.Deserialize<List<Question>>(data["body"].ToString());
            for(int i = 0; i < list.Count; i++)
            {
                LiRQuestion liq = new LiRQuestion(list[i]);
                content.Controls.Add(liq);
            }
        }

        private void testName_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using Win_tests.Classes;
using Win_tests.UserControls;

namespace Win_tests.Wins
{
    public partial class Testing : Form
    {
        int tst_id;
        public int wl_id;
        DataRow data;
        List<Question> questions;
        List<Question> result;
        public Testing(int wl_id)
        {
            this.wl_id = wl_id;
            InitializeComponent();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            DataSet dt = DB.Query("SELECT wall.wl_id, tests.* from wall "+
                " left join tests using(tst_id) " +
                " where wl_id = " + wl_id + " limit 1");
            if (dt.Tables[0].Rows.Count == 1) {
                data = dt.Tables[0].Rows[0];
                testName.Text = data["name"].ToString();
                description.Text = data["description"].ToString();

                questions = JsonSerializer.Deserialize<List<Question>>(data["body"].ToString());
                for (int i = 0; i < questions.Count; i++) {
                    LiTQuestion lt = new LiTQuestion(questions[i]);
                    content.Controls.Add(lt);
                }
            }

           

        }

        private void btn_sendTest_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Вы уверены, что хотите закончить тестирование?", "Внимание!", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes) {
                SendTest();
            }
        }

        public void SendTest() {
            result = new List<Question>(0);
            int score = 0;
            for (int i = 0; i < content.Controls.Count; i++) {
                LiTQuestion lit = ((LiTQuestion)content.Controls[i]);
                Question quest = lit.question;
                string userAnswer = lit.GetAnswer();
                if (userAnswer != quest.answer)
                {
                    quest.score = 0;
                }
                else {
                    score += quest.score;
                }
                quest.answer = userAnswer;
                result.Add(quest);
            }
            string usr_id = Program.user.usr_id.ToString();
            string body = JsonSerializer.Serialize(result);
            Dictionary<string, object> list = new Dictionary<string, object>(0);
            string sql = "INSERT into results (body, date_created, score, usr_id, wl_id) VALUES " +
                "(@body, @date_created, @score, @usr_id, @wl_id)";
            list.Add("body", body);
            list.Add("date_created", DateTime.Now);
            list.Add("score", score);
            list.Add("usr_id", usr_id);
            list.Add("wl_id", wl_id);
            if (DB.PrepareMod(sql, "stiii", list))
            {
                DataSet ds = DB.Query("SELECT res_id from results order by res_id desc limit 1");
                if (ds.Tables[0].Rows.Count == 1) {
                    string res_id = ds.Tables[0].Rows[0]["res_id"].ToString();
                    Result winRes = new Result(Convert.ToInt32(res_id));
                    winRes.Show();
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Ошибка отправки теста", "Ошибка");
            }
            

        }
    }
}

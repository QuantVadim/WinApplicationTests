using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.Classes;
using Win_tests.UserControls;
using System.Text.Json;

namespace Win_tests.Wins
{
    public partial class Test : Form
    {
        string tst_id;
        DataRow data;
        List<Question> questions = new List<Question>(0);
        Question[] arr = new Question[0];

        public delegate void deleg();
        public event deleg OnChange;

        public Test(int tst_id)
        {
            this.tst_id = tst_id.ToString();
            InitializeComponent();
        }
        public Test()
        {
            InitializeComponent();
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            LoadTestInfo();
            
        }

        public void LoadTestInfo() {
            if (tst_id != null)
            {
                DataSet dt = DB.Query("SELECT * from tests where tst_id = " + tst_id + " limit 1");
                if (dt.Tables[0].Rows.Count == 1)
                {
                    data = dt.Tables[0].Rows[0];
                    testName.Text = data["name"].ToString();
                    description.Text = data["description"].ToString();
                    try
                    {
                        questions = JsonSerializer.Deserialize<List<Question>>(data["body"].ToString());
                        UpdateBody();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка", "Ошибка преобразования тела теста");
                    }

                }
            }
            else {
                testName.Text = "Новый тест";
            }
        }

        void UpdateBody() {
            content.Controls.Clear();
            for (int i = 0; i < questions.Count; i++) {
                LiQuestion liq = new LiQuestion(questions[i]);
                liq.onDelete += DeleteQuestion;
                content.Controls.Add(liq);
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            Question ques = new Question("", "", 1);
            LiQuestion liQ = new LiQuestion(ques);
            liQ.onDelete += DeleteQuestion;
            content.Controls.Add(liQ);

        }
        public void DeleteQuestion(int qid)
        {
            for (int i = 0; i < content.Controls.Count; i++) {
                LiQuestion liq = ((LiQuestion)content.Controls[i]);
                if (liq.question.qid == qid) {
                    content.Controls.RemoveAt(i);
                    break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            questions.Clear();
            int counter_score = 0;
            if (testName.Text.Trim().Length == 0) {
                MessageBox.Show("Ведите название теста!", "Ошибка");
                return;
            }

            for(int i = 0; i < content.Controls.Count; i++)
            {
                LiQuestion liq = ((LiQuestion)content.Controls[i]);
                Question quest = liq.GetQuestion();
                questions.Add(quest);
                counter_score += quest.score;
            }
            string body = JsonSerializer.Serialize(questions);
            if (tst_id != null)
            {
                string sql = "UPDATE tests set body = @body, name = @name, description = @description, q_count = @q_count, score = @score where tst_id = @tst_id";
                Dictionary<string, object> par = new Dictionary<string, object>(0);
                par.Add("body", body);
                par.Add("tst_id", tst_id);
                par.Add("name", testName.Text.Trim());
                par.Add("description", description.Text.Trim());
                par.Add("q_count", questions.Count);
                par.Add("score", counter_score);
                if (DB.PrepareMod(sql, "sissii", par))
                {
                    MessageBox.Show("Тест успешно сохранен");
                    if (OnChange != null) OnChange.Invoke();
                }
            }
            else {
                string usr_id = Program.user.usr_id.ToString();
                string sql = "INSERT INTO tests (body, name, description, q_count, score, date_created, usr_id) VALUES " +
                    "(@body, @name, @description, @q_count, @score, @date_created, @usr_id)";
                Dictionary<string, object> par = new Dictionary<string, object>(0);
                par.Add("body", body);
                par.Add("name", testName.Text.Trim());
                par.Add("description", description.Text.Trim());
                par.Add("q_count", questions.Count);
                par.Add("score", counter_score);
                par.Add("date_created", DateTime.Now );
                par.Add("usr_id", Convert.ToInt32(usr_id));
                if (DB.PrepareMod(sql, "sssiiti", par))
                {
                    DataSet dt = DB.Query("SELECT tst_id from tests where usr_id = " + usr_id + " order by tst_id desc limit 1");
                    if (dt.Tables[0].Rows.Count == 1)
                    {
                        DataRow dr = dt.Tables[0].Rows[0];
                        tst_id = dr["tst_id"].ToString();
                        MessageBox.Show("Тест №" + tst_id + " успешно создан");
                        if (OnChange != null) OnChange.Invoke();

                    }

                }
                else {
                    MessageBox.Show("Ошибка создания теста");
                }
            }
            
            
        }

        private void testName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

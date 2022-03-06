using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.Wins;

namespace Win_tests.Wins
{
    public partial class WallResults : Form
    {
        string wl_id;
        List<DataRow> list;
        public WallResults(int wl_id)
        {
            this.wl_id = wl_id.ToString();
            InitializeComponent();
        }

        private void WallResults_Load(object sender, EventArgs e)
        {
            LoadInfo();
            if (Program.user.usr_type == "student") {
                btn_res_delete.Visible = false;
                btn_res_delete.Enabled = false;
            }
        }

        public void LoadInfo() {
            string sql = "SELECT * from wall where wl_id = " + wl_id + " limit 1";
            DataSet dsw = DB.Query(sql);
            if (dsw.Tables[0].Rows.Count == 1)
            {
                label1.Text = dsw.Tables[0].Rows[0]["date_created"].ToString();
            }
            string usr_id = Program.user.usr_id.ToString();


            if (Program.user.usr_type == "student")
            {

                sql = "SELECT results.res_id, results.date_created, " +
                " concat(concat(users.name, ' '), users.last_name) as \"full_name\", " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join users on users.usr_id = results.usr_id " +
                " where results.wl_id = " + wl_id + " and results.usr_id = " + usr_id + " order by res_id desc";
            }
            else
            {
                sql = "SELECT results.res_id, results.date_created, " +
                " concat(concat(users.name, ' '), users.last_name) as \"full_name\", " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join users on users.usr_id = results.usr_id " +
                " where results.wl_id = " + wl_id + " order by res_id desc";
            }

            DataSet dt = DB.Query(sql);

            DataTable dtable = dt.Tables[0];
            list = new List<DataRow>(0);
            dtable.Columns.Add("scoreText");
            dtable.Columns.Add("procent");
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                list.Add(dt.Tables[0].Rows[0]);
                float myscore = Convert.ToSingle(dtable.Rows[i]["score"]);
                float maxscore = Convert.ToSingle(dtable.Rows[i]["score_max"]);
                string scoreText = myscore.ToString() + " из " + maxscore.ToString();
                string procentScore = "--";
                if (maxscore > 0)
                {
                    if (myscore >= maxscore)
                    {
                        procentScore = "100%";
                    }
                    else
                    {
                        procentScore = Math.Round((myscore / maxscore) * 100).ToString() + "%";
                    }
                }
                dtable.Rows[i]["procent"] = procentScore;
                dtable.Rows[i]["scoreText"] = scoreText;
            }
            dtable.Columns.Remove("score");
            dtable.Columns.Remove("score_max");

            dataGrid.DataSource = dtable;
            dataGrid.Columns["full_name"].HeaderText = "Имя";
            dataGrid.Columns["scoreText"].HeaderText = "Баллы";
            dataGrid.Columns["procent"].HeaderText = "Решено";
            dataGrid.Columns["date_created"].HeaderText = "Дата";
            dataGrid.Columns["res_id"].HeaderText = "Код";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                int res_id = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["res_id"].Value);
                Result res = new Result(res_id);
                res.Show();
            }
            
        }

        private void btn_res_delete_Click(object sender, EventArgs e)
        {
            string msg = "Вы уверены, что хотите удалить результат?";
            DialogResult dia = MessageBox.Show(msg, "Подтверждение", MessageBoxButtons.YesNo);
            if (dataGrid.SelectedRows.Count == 1 && dataGrid.Rows.Count > 0)
            {
                if (dia == DialogResult.Yes)
                {
                    int index = dataGrid.SelectedRows[0].Index;
                    string res_id = list[index]["res_id"].ToString();
                    if (DB.Modification_Execute("DELETE FROM results where res_id = " + res_id))
                    {
                        LoadInfo();
                    }
                }
            }

        }
    }
}

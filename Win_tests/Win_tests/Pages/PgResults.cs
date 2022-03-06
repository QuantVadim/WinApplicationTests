using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win_tests.Wins;

namespace Win_tests.Pages
{
    public partial class PgResults : UserControl
    {
        string usr_id = Program.user.usr_id.ToString();
        List<DataRow> list;
        public PgResults()
        {
            InitializeComponent();
        }

        private void PgResults_Load(object sender, EventArgs e)
        {
            LoadInfo();
            if (Program.user.usr_type == "student")
            {
                btn_delete.Visible = false;
                btn_delete.Enabled = false;
            }
        }
        public void LoadInfo() {
            string sql = "SELECT results.res_id, groups.name as \"group_name\", " +
                " tests.name as \"test_name\", results.date_created, " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join groups on groups.gr_id = wall.gr_id " +
                " where results.usr_id = " + usr_id + " order by res_id desc";
            if (Program.user.usr_type == "admin")
            {
                sql = "SELECT results.res_id, groups.name as \"group_name\", " +
                " tests.name as \"test_name\", results.date_created, " +
                " concat(concat(users.name, ' '), users.last_name) as \"user_name\", " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join groups on groups.gr_id = wall.gr_id " +
                " left join users on results.usr_id = users.usr_id " +
                " order by res_id desc";
            }else if (Program.user.usr_type == "teacher")
            {
                sql = "SELECT results.res_id, groups.name as \"group_name\", " +
                " tests.name as \"test_name\", results.date_created, " +
                " concat(concat(users.name, ' '), users.last_name) as \"user_name\", " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join groups on groups.gr_id = wall.gr_id " +
                " left join users on results.usr_id = users.usr_id " +
                " where groups.usr_id = " + usr_id +
                " order by res_id desc";
            }
            DataSet dt = DB.Query(sql);
            ContainData(dt.Tables[0]);
        }

        public void ContainData(DataTable dtable) {
            list = new List<DataRow>(0);
            dtable.Columns.Add("scoreText");
            dtable.Columns.Add("procent");
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                list.Add(dtable.Rows[0]);
                float myscore = Convert.ToSingle(dtable.Rows[i]["score"]);
                float maxscore = Convert.ToSingle(dtable.Rows[i]["score_max"]);
                string scoreText = myscore.ToString() + " из " + maxscore.ToString();
                string procentScore = "--";
                if (maxscore > 0)
                {
                    if (myscore >= maxscore) procentScore = "100%";
                    else procentScore = Math.Round((myscore / maxscore) * 100).ToString() + "%";
                }
                dtable.Rows[i]["procent"] = procentScore;
                dtable.Rows[i]["scoreText"] = scoreText;
            }
            dtable.Columns.Remove("score");
            dtable.Columns.Remove("score_max");

            dataGrid.DataSource = dtable;
            dataGrid.Columns["group_name"].HeaderText = "Группа";
            dataGrid.Columns["test_name"].HeaderText = "Тест";
            dataGrid.Columns["scoreText"].HeaderText = "Баллы";
            dataGrid.Columns["procent"].HeaderText = "Решено";
            dataGrid.Columns["date_created"].HeaderText = "Дата";
            dataGrid.Columns["res_id"].HeaderText = "Код";
            if (Program.user.usr_type == "admin")
                dataGrid.Columns["user_name"].HeaderText = "Пользователь";
        }

        public void FindInfo() {
            string text = tb_finder.Text.Trim();
            string inDate = "";
            string format = "yyyy-MM-dd HH:mm";
            if (dateTimePicker1.Checked && dateTimePicker2.Checked) {
                inDate = " AND results.date_created >= '" + dateTimePicker1.Value.ToString(format) +
                    "' AND results.date_created <= '" + dateTimePicker2.Value.ToString(format) + "'";
            }
            if (dateTimePicker1.Checked && !dateTimePicker2.Checked)
                inDate = " AND results.date_created >= '" + dateTimePicker1.Value.ToString(format) + "'";
            if (!dateTimePicker1.Checked && dateTimePicker2.Checked)
                inDate = " AND results.date_created <= '" + dateTimePicker2.Value.ToString(format) + "'";
            if (inDate.Length == 0 && text.Trim().Length == 0) {
                LoadInfo();
                return;
            }

            string sql = "SELECT results.res_id, groups.name as \"group_name\", " +
                " tests.name as \"test_name\", results.date_created, " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join groups on groups.gr_id = wall.gr_id " +
                " where results.usr_id = " + usr_id + " AND "+
                " ( lower(groups.name) like lower('%" + text + "%') OR " +
                " lower(tests.name) like lower('%" + text + "%') ) " +
                 inDate + " order by res_id desc";
            if (Program.user.usr_type == "admin")
            {
                sql = "SELECT results.res_id, groups.name as \"group_name\", " +
                " tests.name as \"test_name\", results.date_created, " +
                " concat(concat(users.name, ' '), users.last_name) as \"user_name\", " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join groups on groups.gr_id = wall.gr_id " +
                " left join users on results.usr_id = users.usr_id " +
                " where "+
                " (lower(groups.name) like lower('%" + text + "%') OR " +
                " lower(tests.name) like lower('%" + text + "%') OR " +
                " lower(users.last_name) like lower('%" + text + "%') ) " +
                inDate +
                " order by res_id desc";
            }
            else if (Program.user.usr_type == "teacher") {
                sql = "SELECT results.res_id, groups.name as \"group_name\", " +
                " tests.name as \"test_name\", results.date_created, " +
                " concat(concat(users.name, ' '), users.last_name) as \"user_name\", " +
                " results.score, tests.score as \"score_max\" " +
                "  " +
                " from results " +
                " left join wall on wall.wl_id = results.wl_id " +
                " left join tests on tests.tst_id = wall.tst_id " +
                " left join groups on groups.gr_id = wall.gr_id " +
                " left join users on results.usr_id = users.usr_id " +
                " where groups.usr_id = " + usr_id + " AND "+
                "(lower(groups.name) like lower('%" + text + "%') OR " +
                " lower(tests.name) like lower('%" + text + "%') OR " +
                " lower(users.last_name) like lower('%" + text + "%') ) " +
                inDate +
                " order by res_id desc";
            }
            DataSet dt = DB.Query(sql);
            ContainData(dt.Tables[0]);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int res_id = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["res_id"].Value);
                Result res = new Result(res_id);
                res.Show();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
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

        private void btn_find_Click(object sender, EventArgs e)
        {
            FindInfo();
        }

        private void tb_finder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                FindInfo();
            }
        }
    }
}

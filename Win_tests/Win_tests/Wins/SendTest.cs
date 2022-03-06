using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Win_tests.Wins
{
    public partial class SendTest : Form
    {
        string tst_id;
        DataRow data;
        List<DataRow> groups = new List<DataRow>(0);
        public SendTest(int tst_id)
        {
            InitializeComponent();

            this.tst_id = tst_id.ToString();
        }

        private void SendTest_Load(object sender, EventArgs e)
        {
            LoadTestInfo();
            LoadGroupList();
        }

        public void LoadTestInfo() {
            DataSet dt = DB.Query("SELECT * from tests where tst_id = " + tst_id + " limit 1");
            if(dt.Tables[0].Rows.Count == 1)
            {
                data = dt.Tables[0].Rows[0];
                testName.Text = data["name"].ToString();
            }
        }
        public void LoadGroupList()
        {
            string usr_id = Program.user.usr_id.ToString();
            string sql = "SELECT groups.*, classes.name as \"class_name\" from groups " +
                " left join classes using(cls_id) " +
                " where usr_id = " + usr_id + " order by name";
            if (Program.user.usr_type == "admin") 
                sql = "SELECT groups.*, classes.name as \"class_name\" from groups " +
                    " left join classes using(cls_id) order by name";
            DataSet dt = DB.Query(sql);
            groupList.Items.Clear();
            groups = new List<DataRow>(0);
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++) {
                DataRow dr = dt.Tables[0].Rows[i];
                groups.Add(dr);
                groupList.Items.Add(dr["name"].ToString()+" - "+ dr["class_name"].ToString(), false);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string[] arr = new string[groupList.CheckedIndices.Count];
            for (int i = 0; i < groupList.CheckedIndices.Count; i++) {
                arr[i] = groups[groupList.CheckedIndices[i]]["gr_id"].ToString();
            }

            if (arr.Length > 0)
            {
                bool isOk = true;
                for (int i = 0; i < arr.Length; i++)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>(0);
                    string sql = "INSERT into wall (description, date_created, tst_id, gr_id) " +
                        "VALUES (@description, @date_created, @tst_id, @gr_id)";
                    dic.Add("description", tb_comment.Text.Trim());
                    dic.Add("date_created", DateTime.Now);
                    dic.Add("tst_id", tst_id);
                    dic.Add("gr_id", arr[i]);
                    if (!DB.PrepareMod(sql, "stii", dic)) { isOk = false; }
                }
                if (isOk)
                {
                    MessageBox.Show("Тест успешно опубликован " + arr.Length + " раз");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка публикации теста");
                }
            }
            else {
                MessageBox.Show("Необходимо выбрать группы для публикации!");
            }
            
        }
    }
}

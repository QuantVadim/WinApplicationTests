using System;
using System.Collections.Generic;
using System.Text;

namespace Win_tests.Classes
{
    [Serializable]
    public class Question
    {
        public int qid { get; set; }
        public string text { get; set; }
        public string answer { get; set; }
        public int score { get; set; }

        public Question(string text, string answer, int score) {
            Random rand = new Random();
            this.qid = rand.Next(10000000, 99999999);
            this.text = text;
            this.answer = answer;
            this.score = score;
        }
        public Question(string text, string answer, int score, int qid)
        {
            this.qid = qid;
            this.text = text;
            this.answer = answer;
            this.score = score;
        }
        public Question() { 
        
        }
    }
}

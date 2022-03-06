using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Win_tests.Classes
{
    class User
    {
        public int usr_id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string usr_type { get; set; }
        public User(DataRow dt) {
            usr_id = Convert.ToInt32(dt["usr_id"]);
            name = dt["name"].ToString();
            last_name = dt["last_name"].ToString();
            login = dt["login"].ToString();
            password = dt["password"].ToString();
            usr_type = dt["usr_type"].ToString();
        }
    }
}

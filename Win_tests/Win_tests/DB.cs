using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Win_tests
{
    class DB
    {
        public static NpgsqlConnection connection;
        public static DataSet data;
        static string server, user, password, database;

        public static void Initialization(string server, string user, string password, string database)
        {
            DB.server = server;
            DB.user = user;
            DB.password = password;
            DB.database = database;
            DB.Start();
        }
        public static void Start()
        {
            connection = new NpgsqlConnection("Server=" + server + "; User Id=" + user + "; Password=" + password + "; Database=" + database + ";");
            data = new DataSet();
            connection.Open(); // Устанавливаем соединение с базой данных+
        }
        public static void Close()
        {
            connection.Close();
        }
        public static DataSet Query(string sql) {
            DataSet ret = new DataSet();
            NpgsqlDataAdapter dat; // SQL-запрос на создание (обновление) таблицы в DataSet
            dat = new NpgsqlDataAdapter(sql, connection); // Создаем SQL-запрос к БД на основе SQL-команды
            dat.Fill(ret);
            return ret;
        }

        public static void Table_Fill(string name, string sql)
        {
            if (data.Tables[name] != null) //Если таблица в DataSet уже существует,
                data.Tables[name].Clear(); // очищаем таблицу от предыдущих данных
            NpgsqlDataAdapter dat; // SQL-запрос на создание (обновление) таблицы в DataSet
            dat = new NpgsqlDataAdapter(sql, connection); // Создаем SQL-запрос к БД на основе SQL-команды
            dat.Fill(data, name);  //Выполняем SQL-запрос, создавая (обновляя) таблицу в DataSet
        }
        // Добавление (обновление, удаление) данных в БД на основе SQL-команды
        public static bool Modification_Execute(string sql)
        {
            NpgsqlCommand com; // SQL-запрос на добавление (обновление, удаление) данных в БД
            com = new NpgsqlCommand(sql, connection); // Создаем SQL-запрос к БД на основе SQL-команды
            bool ret = false;
            try
            {
                com.ExecuteNonQuery(); // Выполняем SQL-запрос, добавляя (обновляя или удаляя) данные в БД
                ret = true;
            }
            catch (NpgsqlException)
            {
                // исключение при ошибке обращения к источнику данных
                MessageBox.Show("Обновление базы данных не было выполнено из-за не указания обновляемых данных," +
                " несоответствия их типов или данное действие может нарушить целостность базы данных!", "Ошибка");
            }
            return ret;
        }
        public static bool PrepareMod(string sql, string types, Dictionary<string, object> list)
        {
            NpgsqlCommand com; // SQL-запрос на добавление (обновление, удаление) данных в БД
            com = new NpgsqlCommand(sql, connection); // Создаем SQL-запрос к БД на основе SQL-команды
            for (int i = 0; i < list.Count; i++) {
                string key = list.ElementAt(i).Key;
                object val = list[key];
                char ch = types[i];
                switch (ch) {
                    case 'i':
                        com.Parameters.Add(new NpgsqlParameter(key, DbType.Int32));
                        com.Parameters[i].Value = Convert.ToInt32(val);
                        break;
                    case 't':
                        com.Parameters.Add(new NpgsqlParameter(key, DbType.DateTime2));
                        com.Parameters[i].Value = val;
                        break;
                    default:
                        com.Parameters.Add(new NpgsqlParameter(key, DbType.String));
                        com.Parameters[i].Value = val.ToString();
                        break;
                }
            }
            try
            {
                com.Prepare();
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery(); // Выполняем SQL-запрос, добавляя (обновляя или удаляя) данные в БД
            }
            catch (NpgsqlException)
            {
                // исключение при ошибке обращения к источнику данных
                MessageBox.Show("Обновление базы данных не было выполнено из-за не указания обновляемых данных" +
                " или несоответствия их типов!", "Ошибка");
            }
            return true;
        }

    }
}

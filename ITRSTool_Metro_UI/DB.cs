using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ITRSTool_Metro_UI
{
    class DB
    {
    public static string Connector;



        // Класс - получает строку SQL - отдает набор данных
        static public DataTable sql_select_dataset(string sql_string)
        {
            DataTable dt = new DataTable();

            
            string connStr = DB.Connector;


            MySqlConnection connection = new MySqlConnection(connStr);
            MySqlCommand sqlCom = new MySqlCommand(sql_string, connection);
            connection.Open();
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);

            dataAdapter.Fill(dt);


            return dt;
        }
        // Класс - получает строку SQL - делает сохранение
        static public void sql_insert(string sql_string)
        {

            string connStr = DB.Connector;


            MySqlConnection connection = new MySqlConnection(connStr);
            

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandText = sql_string;
                connection.Open();
                int numRowsUpdated_end = command.ExecuteNonQuery();

                command.Dispose();
        }
        // Класс - получает строку SQL - делает сохранение - отдает ID сохраненной строчки
        static public string sql_insert_back(string sql_string)
        {

            string connStr = DB.Connector;


            MySqlConnection connection = new MySqlConnection(connStr);

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandText = sql_string;
                connection.Open();
                //int numRowsUpdated_end = command.ExecuteNonQuery();
                string value = command.ExecuteScalar().ToString();
                command.Dispose();
                return value;

        }
        // Класс - получает строку SQL - делает обновление.
        static public void sql_update(string sql_string)
        {

            string connStr = DB.Connector;
            MySqlConnection cn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql_string;
            cn.Open();
            int numRowsUpdated = cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();


        }
        // Класс - получает строку SQL - отдает одно значение
        static public string Sql_Reader(string sql_string)

        {


            string connStr = DB.Connector;


            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand sqlCom = new MySqlCommand(sql_string, conn);
            conn.Open();
            sqlCom.ExecuteNonQuery();

            string value = sqlCom.ExecuteScalar().ToString();
            conn.Close();

            return value;

        }
        // Класс для проверки соединения с СУБД. Получает строку коннекта, на выходе true, либо false
        public static bool DBConnectionStatus(string connStr)
        {

            try
            {
                using (MySqlConnection sqlConn =
                    new MySqlConnection(connStr))
                {
                    sqlConn.Open();
                    return (sqlConn.State == ConnectionState.Open);
                }
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    }

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
        static public DataTable sql_select_dataset(string sql_string)
        {
            DataTable dt = new DataTable();

            string connStr = Properties.Settings.Default.ConnectionString;


            MySqlConnection connection = new MySqlConnection(connStr);
            MySqlCommand sqlCom = new MySqlCommand(sql_string, connection);
            connection.Open();
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);

            dataAdapter.Fill(dt);


            return dt;
        }
        static public void sql_insert_dataset(string sql_string)
        {

            string connStr = Properties.Settings.Default.ConnectionString;


            using (MySqlConnection connection = new MySqlConnection(connStr))
            {

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandText = sql_string;
                connection.Open();
                int numRowsUpdated_end = command.ExecuteNonQuery();

                command.Dispose();

            }



        }
        static public string sql_insert_back(string sql_string)
        {

            string connStr = Properties.Settings.Default.ConnectionString;


            using (MySqlConnection connection = new MySqlConnection(connStr))
            {

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandText = sql_string;
                connection.Open();
                //int numRowsUpdated_end = command.ExecuteNonQuery();
                string value = command.ExecuteScalar().ToString();
                command.Dispose();
                return value;
            }



        }
        static public void sql_update_dataset(string sql_string)
        {

            string connStr = Properties.Settings.Default.ConnectionString;
            MySqlConnection cn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql_string;
            cn.Open();
            int numRowsUpdated = cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();


        }

        static public string Sql_Reader(string sql_string)

        {


            string connStr = Properties.Settings.Default.ConnectionString;


            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand sqlCom = new MySqlCommand(sql_string, conn);
            conn.Open();
            sqlCom.ExecuteNonQuery();

            string value = sqlCom.ExecuteScalar().ToString();
            conn.Close();

            return value;

        }
    }
    }

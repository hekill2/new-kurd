using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Connection_DB
{
    class Connection
    {

        MySql.Data.MySqlClient.MySqlConnection Conn;
        //private readonly string myConnectionString;
        static string host = "localhost";
        static string database = "kursach";
        static string userDB = "root";
        static string password = "5478541";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
                Conn = new MySqlConnection(strProvider);
                Conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void Close()
        {
            Conn.Close();
            Conn.Dispose();
        }
        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
  
        ///////////////////////////////////////////
        
        public MySqlDataReader ExecuteReaderTable(string sql)
        {
            try
            {
                MySqlDataReader readtabl;
                MySqlCommand cmd = new MySqlCommand(sql, Conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;

        }
        
        /// //////////////////////////////////////////
        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = Conn.BeginTransaction();
                MySqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
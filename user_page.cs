using Connection_DB;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Kursovoe
{
    public partial class user_page : Form
    {
        Connection con = new Connection();
        Home_page hom = new Home_page();
       // dateperemen dat = new dateperemen();
        string pass;
        public user_page()
        {
            InitializeComponent();
            //hom.CreateMenuBar();

        }

        private void user_page_Load(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                string query = "SELECT name_,number_,password_,email_ FROM users WHERE id_user ='" + dateperemen.peremen + "'";
                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        label1.Text = row["name_"].ToString();
                        label2.Text = row["number_"].ToString();
                        label3.Text = row["email_"].ToString();
                        pass = row["password_"].ToString();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("помилка авторизації", "Information");
                    this.Hide();
                    ButtAutoreg form = new ButtAutoreg();
                    form.Show();
                }

            }
            catch
            {
                MessageBox.Show("Помилка з'єднання", "Information");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordreplaс();

        }
        private void ClicButtonPasNew(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE users SET password_ ='" + textpassnew.Text + "' WHERE password_ ='" + textpass.Text + "'AND id_user ='" + dateperemen.peremen + "'";
                MySqlDataReader row;
                row = con.ExecuteReader(query);

                MessageBox.Show("Пароль змінено", "Information");
                this.Hide();
                ButtAutoreg form = new ButtAutoreg();
                form.Show();
            }
            catch
            {
                MessageBox.Show("Помилка з'єднання", "Information");
            }
        }











        








    }
    
}

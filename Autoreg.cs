using Connection_DB;
using MySql.Data.MySqlClient;
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
    public partial class Autoreg : Form
    {
        Connection con = new Connection();
        public Autoreg()
        {
            InitializeComponent();
        }

        private void Autoreg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textName.Text != "" && maskedTextBox1.Text != "" && textPost.Text != "" && textPass.Text != "")
                {
                    con.Open();
                    string query = "INSERT INTO users (name_, number_,email_,password_) VALUES ('" + textName.Text + "','" + maskedTextBox1.Text + "','" + textPost.Text + "','" + textPass.Text + "')";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);


                    this.Hide();
                    Home_page home_page = new Home_page();
                    home_page.Show();

                }
                else
                {
                    MessageBox.Show("Внесені не всі данні для реєстрації", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Помилка з'єднання", "Information");
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ButtAutoreg form = new ButtAutoreg();
            form.Show();
        }


    }
}

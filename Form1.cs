using Connection_DB;
using MySql.Data.MySqlClient;

namespace Kursovoe
{
    public partial class ButtAutoreg : Form
    {
        Connection con = new Connection();
       // dateperemen dat = new dateperemen();
        string NaMe="";
        public ButtAutoreg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && txtPassword.Text != "")
                {
                    con.Open();
                    string query = "SELECT id_user FROM users WHERE number_ ='" + textBox1.Text + "' AND password_ ='" + txtPassword.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            dateperemen.peremen = Int32.Parse(row["id_user"].ToString());
                             
                        }
                        con.Close();

                        this.Hide();
                        Home_page home_page = new Home_page();
                        home_page.Show();
                    }
                    else
                    {
                        MessageBox.Show("Логін або пароль помилкові", "Information");
                        this.Hide();
                        ButtAutoreg form = new ButtAutoreg();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ім'я користувача або пароль порожні", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Помилка з'єднання", "Information");
            }
        }
        private void labelAutoreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Autoreg autoreg = new Autoreg();
            autoreg.Show();


        }
    }
}

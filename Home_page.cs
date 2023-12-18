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
using System.IO;
//OrderHistory
namespace Kursovoe
{
    public partial class Home_page : Form
    {
        //PlacingAnOrder placing = new PlacingAnOrder();
        //dateperemen pri = new dateperemen();
        Connection con = new Connection();
        double AllPrice=0;
        public Home_page()
        {
            InitializeComponent();
            CreateMenuBar();
        }
        public List<Dish> menu = new List<Dish>();
        public List<AddFood> Basket = new List<AddFood>();
        private void LoadMenuFromDB()
        {
            try
            {
                if (true)
                {
                    con.Open();
                    string query = "SELECT menu.*,category.name_cat FROM menu JOIN category ON menu.id_cat = category.id_cat";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            Dish dish = new Dish();
                            //dateperemen.peremen = Int32.Parse(row["id_user"].ToString());
                            dish.id = Convert.ToInt32(row["dish_id"].ToString());
                            dish.name = row["dish_name"].ToString();
                            dish.prise = Convert.ToDouble(row["dish_price"].ToString());
                            dish.description = row["dish_description"].ToString();
                            dish.fileNameImage = row["image"].ToString();
                            dish.nameCate = row["name_cat"].ToString();
                            //Dish dish = new Dish(name, prise, description, fileNameImage);
                            menu.Add(dish);
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("помилка читання бази", "Information");
                        this.Hide();
                        Home_page homepage = new Home_page();
                        homepage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ім'я користувача або пароль порожні", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HomePageLoad(object sender, EventArgs e)
        {
           // basketPlas(1);
            LoadMenuFromDB();
            showDish("Бургери");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // this.Hide();
            user_page userpage = new user_page();
            //Home_page home_pages = new Home_page(this);
            userpage.Show();
        }

        /* private void pictureBox6_Click(object sender, EventArgs e)
         {
             // this.Hide();
             //basket basket_ = new basket();
             //Home_page home_pages = new Home_page(this);
             //basket_.Show();
             basket basketForm = new basket();
             basketForm.SetBasket(Basket); // Assuming Basket is accessible in the current context.
             basketForm.ShowDialog();
         }*/
        void showDish(string cat)
        {
            for (int i = 1; i <= 10; i++)
            {
                PictureBox picture = (PictureBox)Controls.Find($"pbDish{i}", true)[0];
                Label labe = (Label)Controls.Find($"labelDish{i}", true)[0];
                Label pris = (Label)Controls.Find($"prise{i}", true)[0];
                //pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\" + menu[i].fileNameImage)
                picture.Image = null;
                labe.Text = "";
                pris.Text = "";
            }
            int pb = 1;
            for (int i = 0; i < menu.Count && pb <= 10; i++)
            {
                if (menu[i].nameCate == cat)
                {
                    PictureBox pictureBox = (PictureBox)Controls.Find($"pbDish{pb}", true)[0];
                    Label label = (Label)Controls.Find($"labelDish{pb}", true)[0];
                    Label prise = (Label)Controls.Find($"prise{pb}", true)[0];
                    //pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\" + menu[i].fileNameImage)
                    pictureBox.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "Image", menu[i].fileNameImage));
                    label.Text = menu[i].name;
                    prise.Text = "Ціна:" + Convert.ToString(menu[i].prise) + "грн";
                    pb++;
                }
            }
        }
        /// / / // //  /
        public void SetBasket(List<AddFood> basket)
        {
            basketListBox.Items.Clear();
            double allprise = 0;

            foreach (AddFood dish in basket)
            {
                
                basketListBox.Items.Add(dish.name + "\t" + dish.prise + "грн" + "\t" + dish.amount);
                // basketListBox.Items.Add();
                allprise += dish.prise * dish.amount; //pri.Allprise = allprise;
            }
            laballprise.Text = "До сплати: " + allprise + "грн";
            AllPrice = allprise;
        }
        private void basketPlus(int pb)
        {
            try
            {
                int j = 0;
                for (int i = 0; i < menu.Count && pb <= 10; i++)
                {
                    Label label = (Label)Controls.Find($"labelDish{pb}", true)[0];

                    if (label != null && label.Text == menu[i].name)
                    {
                        AddFood dishB = new AddFood();
                        dishB.id = menu[i].id;
                        dishB.name = menu[i].name;
                        dishB.prise = Convert.ToInt32(menu[i].prise);
                        dishB.amount = 1;
                        // dishB.fileNameImage = menu[i].fileNameImage;

                        if (!Basket.Any(item => item.name == menu[i].name))
                        {
                            Basket.Add(dishB);
                        }
                        else
                        {
                            int index = Basket.FindIndex(item => item.name == menu[i].name);
                            if (index != -1)
                            {
                                Basket[index].amount++;
                            }
                        }
                    }
                    else { }
                }
                SetBasket(Basket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // / // / / / / / / / / 
        public void CreateMenuBar()
        {
            // Створення головного меню
            MenuStrip mainMenu = new MenuStrip();

            // Створення пункта меню зі списком
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("");

            ToolStripMenuItem men = new ToolStripMenuItem("");
            //ToolStripMenuItem basket = new ToolStripMenuItem("");


            // Створення елементів підменю
            ToolStripMenuItem historyItem = new ToolStripMenuItem("Історія замовлень");
            ToolStripMenuItem contactsItem = new ToolStripMenuItem("Контакти");
            ToolStripMenuItem complaintItem = new ToolStripMenuItem("Поскаржитись");
            ToolStripMenuItem ExitItem = new ToolStripMenuItem("Вийти");

            // Додавання підменю до головного меню
            fileMenu.DropDownItems.Add(historyItem);
            fileMenu.DropDownItems.Add(contactsItem);
            fileMenu.DropDownItems.Add(complaintItem);
            fileMenu.DropDownItems.Add(ExitItem);

            // Додавання головного меню до форми
            mainMenu.Items.Add(fileMenu);
            mainMenu.Items.Add(men);
            // mainMenu.Items.Add(basket);
            // Налаштування подій для пунктів меню
            // basket.Image = Properties.Resources.shopping_cart;
            // basket.Click += pictureBox6_Click;
            contactsItem.Click += contact;
            ExitItem.Click += close;
            historyItem.Click += orderH;
            fileMenu.Image = Properties.Resources.free_icon_font_menu_burger_3917762;
            //fileMenu.Click += pictureBox4_Click;
            ExitItem.Image = Properties.Resources.exit;
            //exitItem.Click += ExitItem_Click;
            men.Image = Properties.Resources.free_icon_font_user_3917688;
            men.Click += pictureBox5_Click;

            // // // // // // // // // // // 
            mainMenu.BackColor = Color.LightBlue;
            mainMenu.Size = new Size(97, 74);
            
            // Додавання меню на форму
            this.Controls.Add(mainMenu);
        }
        public void contact(object sender, EventArgs e)
        {
            Contact cont = new Contact();
            cont.Show();
        }
        public void orderH(object sender, EventArgs e)
        {
            OrderHistory ord = new OrderHistory();
            ord.Show();
        }
        private void close(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showDish("Бургери");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showDish("Шаурма");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            showDish("Хот-доги");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            showDish("соуси");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            showDish("Гарячі-напої");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            showDish("Холодні-напої");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            showDish("Фрітюр");
        }

        private void pbDish1_Click(object sender, EventArgs e)
        {
            basketPlus(1);
        }

        private void pbDish2_Click(object sender, EventArgs e)
        {
            basketPlus(2);
        }

        private void pbDish3_Click(object sender, EventArgs e)
        {
            basketPlus(3);
        }

        private void pbDish4_Click(object sender, EventArgs e)
        {
            basketPlus(4);
        }

        private void pbDish5_Click(object sender, EventArgs e)
        {
            basketPlus(5);
        }

        private void pbDish6_Click(object sender, EventArgs e)
        {
            basketPlus(6);
        }

        private void pbDish7_Click(object sender, EventArgs e)
        {
            basketPlus(7);
        }

        private void pbDish8_Click(object sender, EventArgs e)
        {
            basketPlus(8);
        }

        private void pbDish9_Click(object sender, EventArgs e)
        {
            basketPlus(9);
        }

        private void pbDish10_Click(object sender, EventArgs e)
        {
            basketPlus(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            basketListBox.Items.Clear();
            Basket.Clear();
            laballprise.Text = "";
        }

        public void placing(DateTimePicker dateTimePicker1,CheckBox checkBoxord)
        {
            DateTime currentDateTime = DateTime.Now;
            //MessageBox.Show("" +currentDateTime.ToString("yyyy-MM-dd "));
            // DateTime curDateTime = DateTime.Now;
            TimeSpan rentDateTime = new TimeSpan(0, 20, 0);
            DateTime curDateTime = currentDateTime.Add(rentDateTime);
            int id=0;
            try
            {
                if (checkBoxord.Checked)
                {
                    con.Open();
                    string query = "INSERT INTO order_ (time_ord, time_readiness,id_user,prise_order) VALUES ('" + currentDateTime.ToString("yyyy-MM-dd H:mm:ss ") + "','" + curDateTime.ToString("yyyy-MM-dd H:mm:ss") + "','" + dateperemen.peremen + "','" + AllPrice + "')";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                }
                else
                {
                   con.Open();
                    string query = "INSERT INTO order_ (time_ord, time_readiness,id_user,prise_order) VALUES ('" + currentDateTime.ToString("yyyy-MM-dd H:mm:ss ") + "','"+ currentDateTime.ToString("yyyy-MM-dd ") + Convert.ToString(dateTimePicker1.Text) + "','" + dateperemen.peremen + "','" + AllPrice + "')";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                }

                con.Open();
                string que = "SELECT id_order FROM order_ WHERE time_ord ='" + currentDateTime.ToString("yyyy-MM-dd H:mm:ss ") + "'";
                MySqlDataReader r;
                r = con.ExecuteReader(que);
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        id = Int32.Parse(r["id_order"].ToString());

                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("ти лох(шукати за часом була хренова ідея)", "Information");
                }

                for (int i=0;i<Basket.Count ;i++ )
                {
                    con.Open();
                    string quer = "INSERT INTO item (id_order, dish_id,num_dish) VALUES ('" + id + "','" + Basket[i].id + "','" + Basket[i].amount + "')";
                    MySqlDataReader ro;
                    ro = con.ExecuteReader(quer);
                }
                MessageBox.Show("Замовлення передано до ресторану");
                butt();
            }
            catch
            {
                MessageBox.Show("Помилка з'єднання", "Information");
            }

        }

        private void butt()
        {
            basketListBox.Items.Clear();
            Basket.Clear();
            laballprise.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlacingAnOrder homepage = new PlacingAnOrder(this,AllPrice);
            homepage.Show();
        }



    }

}

using Connection_DB;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoe
{
    public partial class OrderHistory : Form
    {
        Connection con = new Connection();
        public List<History> history = new List<History>();
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            GetDishes();
            Gethisto();
        }

        private void Gethisto()
        {
            // Предположим, у вас есть DataGridView с именем dataGridView1
            dataGridView1.AutoGenerateColumns = false; // Отключаем автогенерацию столбцов

            // Создаем и добавляем столбцы для DataGridView
            dataGridView1.Columns.Add("id_order", "Номер замовлення");
            dataGridView1.Columns.Add("time_ord", "Час замовлення");
            dataGridView1.Columns.Add("prise_order", "Сума замовлення");

            // Затем добавляем столбцы для блюд
            dataGridView1.Columns.Add("dish_name", "Страви");
            dataGridView1.Columns.Add("num_dish", "Кількість страв");

            // Заполняем DataGridView из списка history
            foreach (History h in history)
            {
                // Добавляем основную информацию о заказе
                dataGridView1.Rows.Add("№"+h.id_order, h.time_ord, h.prise_order+"грн");

                // Добавляем строки для каждого блюда
                foreach (Di_Num d in h.Dish_Nu)
                {
                    dataGridView1.Rows.Add("", "", "", d.dish_name, d.num_dish+"шт");
                }
            }

        }
        private void GetDishes()
        {
            try
            {
                if (true)
                {
                    con.Open();
                    string query = "SELECT item.id_order, item.num_dish,order_.time_ord,order_.prise_order,menu.dish_name FROM item JOIN order_ ON item.id_order = order_.id_order JOIN menu ON item.dish_id = menu.dish_id WHERE order_.id_user = '" + dateperemen.peremen + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            History hist = new History();

                            hist.id_order = Convert.ToInt32(row["id_order"].ToString());
                            hist.time_ord = row["time_ord"].ToString();
                            hist.prise_order = Convert.ToInt32(row["prise_order"].ToString());
                            hist.Dish_Nu = GetDishesForOrder(hist.id_order);
                            if(IsHistoryUnique(hist.id_order))
                            {
                                history.Add(hist);
                            }
                            

                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("помилка читання бази", "Information");
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

        private bool IsHistoryUnique(int orderId)
        {
            foreach (History h in history)
            {
                if (h.id_order == orderId)
                {
                    // Данные с таким orderId уже существуют
                    return false;
                }
            }
            // Данные уникальны
            return true;
        }

        private List<Di_Num> GetDishesForOrder(int idord)
        {
            List<Di_Num> dishes = new List<Di_Num>();

            //string query = "SELECT * FROM Dishes WHERE id_order = @OrderId";
            Connection con = new Connection();
            try
            {
                if (true)
                {
                    con.Open();//SELECT * FROM Dishes WHERE id_order ='"+idord+"'
                    string query = "SELECT menu.dish_name,item.num_dish FROM item JOIN menu ON item.dish_id = menu.dish_id WHERE item.id_order ='" + idord + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {

                            Di_Num dishItem = new Di_Num
                            {
                                dish_name = row["dish_name"].ToString(),
                                num_dish = row["num_dish"].ToString()
                            };



                            dishes.Add(dishItem);

                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("помилка читання бази", "Information");
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
            return dishes;
        }
    }
}

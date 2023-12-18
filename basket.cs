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
    public partial class basket : Form
    {
        Dish bas = new Dish();
        public basket()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void basket_Load(object sender, EventArgs e)
        {
            // string d = ;
            //d=menu[1].nameCate;
            // MessageBox.Show(d);
           // listBox1 = bas.Basket[1].name;
           //for(int i=0;i<Basket.Count ;i++ )
            //listBox1.Items.Add(Basket[i].name);

           
        }
        public void SetBasket(List<Dish> basket)
        {
            listBox1.Items.Clear();

            foreach (Dish dish in basket)
            {
                listBox1.Items.Add(dish.name);
                // You can display other properties of the Dish as needed.
            }
        }
    }
}

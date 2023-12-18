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
    public partial class PlacingAnOrder : Form
    {
        public PlacingAnOrder()
        {
            InitializeComponent();
        }
        public PlacingAnOrder(Home_page hp,double all)
        {
            InitializeComponent();
            currentHome_pagehp = hp;
            AllPrice = all;
        }
        Home_page currentHome_pagehp;
        double AllPrice;
        private void PlacingAnOrder_Load(object sender, EventArgs e)
        {
            sumPlacing.Text ="До сплати :"+Convert.ToString(AllPrice)+"грн";

        }

        private void buttonsham_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(dateTimePicker1.Text);
            currentHome_pagehp.placing(dateTimePicker1, checkBoxord);
            this.Hide();
        }

    }
}

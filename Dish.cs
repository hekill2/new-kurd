using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kursovoe
{
    public class Dish
    {

        public Dish()
        {

        }
        public Dish(string name,double prise,string description, string fileNameImage)
        {
            id = 0;
            this.name = name;
            this.prise = prise;
            this.description = description;
            this.fileNameImage = fileNameImage;
        }
        public Dish(string info)
        {
            if(info.Length>0)
            {
                string[] val = info.Split('|');
                for(int i=0;i<val.Length;i++)
                {
                    name = val[1];
                    prise = Convert.ToInt32(val[2]);
                    description = val[3];
                    fileNameImage = val[4];
                }
            }
        }
        public int id;
        public string name { get; set; }
        public double prise { get; set; }
        public string description { get; set; }

        public List<Product> products = new List<Product>();
        public string fileNameImage { get; set; }
        public string nameCate { get; set; }

    }

    public class Product
    {
        public Product()
        {

        }

        public Product(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                for (int i = 0; i < val.Length; i++)
                {
                    nameprod = val[1];
                    quantity = Convert.ToInt32(val[2]);
                    seesod = val[3];
                }
            }
        }

        public Product( string nameprod, string seesod, int quantity)
        {
            this.nameprod = nameprod;
            this.seesod = seesod;
            this.quantity = quantity;
        }
        public string nameprod { get; set; }
        public string seesod { get; set; }
        public int quantity { get; set; }

    }

    public class AddFood
    {
        public AddFood()
        {

        }
        public AddFood(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                for (int i = 0; i < val.Length; i++)
                {
                    id= Convert.ToInt32(val[1]);
                    name = val[2];
                    prise = Convert.ToInt32(val[3]);
                    amount = Convert.ToInt32(val[4]);
                }
            }
        }
        public AddFood(int id,string name, int amount, int prise)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.prise = prise;
        }
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public int prise { get; set; }
        //public Button amou;
        

    }

    public class History
    {
        public History()
        {

        }
        public History(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                for (int i = 0; i < val.Length; i++)
                {
                    id_order = Convert.ToInt32(val[1]);
                    time_ord = val[2];
                    prise_order = Convert.ToInt32(val[3]);
                   // amount = Convert.ToInt32(val[4]);
                }
            }
        }
        public History(int id, string time_ord, int amount, int prise)
        {
            this.id_order = id;
            this.time_ord = time_ord;
            //this.amount = amount;
            this.prise_order = prise;
        }
        public int id_order { get; set; }
        public string time_ord { get; set; }
        //public int amount { get; set; }
        public int prise_order { get; set; }

        public List<Di_Num> Dish_Nu = new List<Di_Num>();

    }

    public class Di_Num
    {
        public Di_Num()
        {

        }

        public Di_Num(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                for (int i = 0; i < val.Length; i++)
                {
                    dish_name = val[1];
                    num_dish = val[2];
                }
            }
        }

        public Di_Num(string num_dish, string dish_name)
        {
            this.dish_name = dish_name;
            this.num_dish = num_dish;
            
        }
        public string dish_name { get; set; }
        public string num_dish { get; set; }

    }



    public class dateperemen
    {
        public static int peremen;
    }
}

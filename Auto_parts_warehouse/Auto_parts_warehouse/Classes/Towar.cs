using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_parts_warehouse.Classes
{
    public class Towar
    {
        public int id { get; set; }

        private string title, description, image, price;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public Towar() { }
        public Towar(string title, string description, string image, string price)
        {
            this.title = title;
            this.description = description;
            this.image = image;
            this.price = price;
        }
    }
}

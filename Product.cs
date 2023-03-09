using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class Product
    {
        public int number;
        public string name;
        public int price;
        public int quantity;
        public int min_quantity;
        public int req_quantity;
        public Product(int number, string name, int price, int quantity, int min_quantity, int req_quantity)
        {
            this.number = number;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.min_quantity = min_quantity;
            this.req_quantity = req_quantity;
        }
        public void auto_req()
        {
            quantity += req_quantity;
        }
        public void req(int quantity)
        {
            quantity += quantity;
        }

    }

}


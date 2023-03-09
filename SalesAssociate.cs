using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class SalesAssociate:Employee

    {
        public double bonus = 0;
        public double fixed_amount { get; set; }
        public void sale_product(int id, int amount)
        {
            foreach (Product product in Inventory.Products)
            {
                if (product.number == id && product.quantity >= amount)
                {
                    double total_price = product.price * 0.01;
                    product.quantity -= amount;
                }

            }
        }
        public override void get_salary(int Id )
        {
            salary = fixed_amount + bonus;
        }
    }
}

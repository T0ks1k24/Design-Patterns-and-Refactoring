using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2.Services
{
    class Shipping
    {
        public void ShipOrder(string orderDetails)
        {
            Console.WriteLine($"Замовлення '{orderDetails}' успішно відправлено.");
        }
    }
}

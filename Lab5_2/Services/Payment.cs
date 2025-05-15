using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2.Services
{
    class Payment
    {
        public bool ProcessPayment(decimal amount, string paymentDetails)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сума платежу має бути більше 0.");
                return false;
            }
            
            Console.WriteLine($"Платіж на суму {amount:C} успішно оброблено через {paymentDetails}.");
            return true;
        }
    }
}

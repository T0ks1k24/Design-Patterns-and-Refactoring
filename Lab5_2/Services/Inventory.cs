using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2.Services
{
    class Inventory
    {
        private Dictionary<int, int> _stock = new Dictionary<int, int>
        {
            {1,10 },
            {2,5 },
            {3,23 }
        };

        public bool CheckAvailability(int productId, int quantity)
        {
            return _stock.ContainsKey(productId) && _stock[productId] >= quantity;
        }

        public void RemoveItems(int productId, int quantity)
        {
            if (CheckAvailability(productId, quantity))
            {
                _stock[productId] -= quantity;
                Console.WriteLine($"Видалено {quantity} одиниць товару з ID {productId}. Залишилось: {_stock[productId]}");
            }
            else
            {
                Console.WriteLine($"Недостатньо товару з ID {productId} для видалення.");
            }

        }
    }
}

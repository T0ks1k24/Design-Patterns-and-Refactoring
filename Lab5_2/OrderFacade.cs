using Lab5_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class OrderFacade
    {
        private readonly Inventory _inventory;
        private readonly Payment _payment;
        private readonly Shipping _shipping;

        public OrderFacade(Inventory inventory, Payment payment, Shipping shipping)
        {
            _inventory = inventory;
            _payment = payment;
            _shipping = shipping;
        }

        public void PlaceOrder(int productId, int quantity, decimal amount, string paymentDetails, string shippingAddress)
        {
            Console.WriteLine("\n--- Оформлення замовлення ---");
            if(!_inventory.CheckAvailability(productId, quantity))
            {
                Console.WriteLine("Помилка: недостатньо товару на складі.");
                return;
            }

            if(!_payment.ProcessPayment(amount, paymentDetails))
            {
                Console.WriteLine("Помилка: платіж не вдалося здійснити.");
                return;
            }

            _inventory.RemoveItems(productId, quantity);

            _shipping.ShipOrder($"Товар ID: {productId}, Кількість: {quantity}, Адреса: {shippingAddress}");
            Console.WriteLine("--- Замовлення успішно оформлене! ---\n");
        }
    }
}

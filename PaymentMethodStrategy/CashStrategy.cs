using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategy
{
    public class CashStrategy : IPaymentMethodStrategy
    {
        public void Discount(TShirt tshirt, decimal? percentage)
        {
            if (percentage == null)
            {
                tshirt.Price = tshirt.Price - tshirt.Price * 0.02m;
            }
            else
            {
                tshirt.Price = tshirt.Price - tshirt.Price * (decimal)percentage;
            }
        }

        public bool Pay(decimal amount)
        {
            if (amount < 0m || amount > 2000)
            {
                Console.WriteLine($"Paying {amount} using Cash declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Cash accepted");

                return true;
            }
        }
    }
}

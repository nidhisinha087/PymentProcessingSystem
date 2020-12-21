using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PymentProcessingSystem.PaymentFactory
{
    public class Video : IPaymentAction
    {
        public int Id { get; set; }
        public void PaymentAction()
        {
            Console.WriteLine("Generating a packaging slip for Shipping");
            Console.WriteLine("Add a free “First Aid” video");
        }
    }
}

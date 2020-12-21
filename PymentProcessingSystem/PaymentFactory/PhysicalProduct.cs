using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PymentProcessingSystem.PaymentFactory
{
    public class PhysicalProduct : IPaymentAction
    {
        public void PaymentAction()
        {
            Console.WriteLine("Generate a packing slip for shipping");
        }
    }
}

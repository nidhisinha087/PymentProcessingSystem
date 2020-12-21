using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PymentProcessingSystem.PaymentFactory
{
   public class Book :IPaymentAction
    {
        public void PaymentAction()
        {
            Console.WriteLine("Create a packing slip for the shipping.");
            Console.WriteLine("create a duplicate packing slip for the royalty department.");
        }

        
    }
}

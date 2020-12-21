using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PymentProcessingSystem.PaymentFactory
{
   public class NewMemberShip : IMembershipPaymentType, IPaymentAction
    {
       
      public string MemberShipType { get; set;}

        public void PaymentAction()
        {
            Console.WriteLine("Activate membership");
        }

       
    }
}

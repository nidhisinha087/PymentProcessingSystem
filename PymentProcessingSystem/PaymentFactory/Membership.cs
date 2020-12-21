using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PymentProcessingSystem.PaymentFactory
{
    public class Membership : IPaymentAction
    {
        IMembershipPaymentType memberShipType;
    
        public Membership(IMembershipPaymentType memberType)
        {
            this.memberShipType = memberType;
        }
        public void PaymentAction()
        {
            this.PaymentAction();
            Console.WriteLine("Email the owner and inform of the Upgrade");
        }
    }
}

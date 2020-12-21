using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PymentProcessingSystem.PaymentFactory
{
  public class UpgardeMembership :IMembershipPaymentType
    {
        public string MemberShipType { get; set; }

        public void PaymentAction()
        {
            Console.WriteLine("Apply the Upgrade");
        }
    }
}

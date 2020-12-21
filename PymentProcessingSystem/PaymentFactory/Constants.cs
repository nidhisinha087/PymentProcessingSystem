using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PymentProcessingSystem.PaymentFactory
{
  public static  class Constants
    {
        public enum Category
        {
            PhysicalProduct=0,
            Book=1,
            Membership=2,
            Video=3
        }

        public enum MemberPaymentShipType
        {
            NewMembership=0,
            UpgradeMembership = 1
        }
    }
}

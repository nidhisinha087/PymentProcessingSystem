using System;
using PymentProcessingSystem.PaymentFactory;

namespace PymentProcessingSystem.PaymentFactory
{
  public  class GeneratePaymentFactory 
    {
      
        public IPaymentAction GeneratePaymentAction(int categoryType, int memberShipType=0)
        {
            IPaymentAction paymentAction = null;
            if (categoryType.Equals(Constants.Category.Book))
            {
               return paymentAction = new Book();
            }
            else if(categoryType.Equals(Constants.Category.Membership))
            {
                IMembershipPaymentType memberShipPaymentType = null;
                if (memberShipType.Equals(Constants.MemberPaymentShipType.NewMembership))
                {
                    memberShipPaymentType = new NewMemberShip();
                }
                else if(memberShipType.Equals(Constants.MemberPaymentShipType.UpgradeMembership))
                {
                    memberShipPaymentType = new UpgardeMembership();
                }
                
                return paymentAction = new Membership(memberShipPaymentType);
            }
            else if(categoryType.Equals(Constants.Category.PhysicalProduct))
            {
                paymentAction = new PhysicalProduct();
            }
            else
            {
                paymentAction = new Video();
            }

            return paymentAction;
        }
       
    }
}

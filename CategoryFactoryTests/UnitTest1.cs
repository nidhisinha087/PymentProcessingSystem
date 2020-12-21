using Microsoft.VisualStudio.TestTools.UnitTesting;
using PymentProcessingSystem;
using PymentProcessingSystem.PaymentFactory;

namespace CategoryFactoryTests
{
    
        [TestClass]
        public class PaymentFactoryUnitTest
        {
        [TestMethod]
        public void Payment_Factory_Creates_Video(int paymentCategory, int membershipPaymentType)
        {
            //Arrange
            var paymentFactory = new PymentProcessingSystem.PaymentFactory.GeneratePaymentFactory();
            var item = new Video();
           



              //Act
               var actual = paymentFactory.GeneratePaymentAction(3);
                

                //Assert
                Assert.IsNotNull(actual);
                Assert.IsInstanceOfType(actual, typeof(Video));

               
            }
        

    [TestMethod]
    public void Payment_Factory_Creates_Book(int paymentCategory, int membershipPaymentType)
    {
        //Arrange
        var paymentFactory = new PymentProcessingSystem.PaymentFactory.GeneratePaymentFactory();
        var item = new Book();




        //Act
        var actual = paymentFactory.GeneratePaymentAction(1);


        //Assert
        Assert.IsNotNull(actual);
        Assert.IsInstanceOfType(actual, typeof(Book));


    }
        [TestMethod]
        public void Payment_Factory_Creates_NewMembership(int paymentCategory, int membershipPaymentType)
        {
            IMembershipPaymentType membershipPayment = new NewMemberShip();
            //Arrange
            var paymentFactory = new PymentProcessingSystem.PaymentFactory.GeneratePaymentFactory();
            var item = new Membership(membershipPayment);




            //Act
            var actual = paymentFactory.GeneratePaymentAction(2,0);


            //Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(Membership));


        }

        [TestMethod]
        public void Payment_Factory_Creates_UpgradeMembership(int paymentCategory, int membershipPaymentType)
        {
            IMembershipPaymentType membershipPayment = new UpgardeMembership();
            //Arrange
            var paymentFactory = new PymentProcessingSystem.PaymentFactory.GeneratePaymentFactory();
            var item = new Membership(membershipPayment);




            //Act
            var actual = paymentFactory.GeneratePaymentAction(2, 1);


            //Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(Membership));



        }
        [TestMethod]
        public void Payment_Factory_Creates_PhysicalProduct(int paymentCategory, int membershipPaymentType)
        {
           
            //Arrange
            var paymentFactory = new PymentProcessingSystem.PaymentFactory.GeneratePaymentFactory();
          




            //Act
            var actual = paymentFactory.GeneratePaymentAction(0);


            //Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(PhysicalProduct));


        }
    }
}

}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DI.PoorMansContainer;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IBillingProcessor> mockBilling =
                new Mock<IBillingProcessor>();

            Mock<ICustomer> mockCustomer =
                new Mock<ICustomer>();

            Mock<INotifier> mockNotifier =
                new Mock<INotifier>();

            Mock<ILogger> mockLogger =
                new Mock<ILogger>();

            mockBilling.Setup(
                obj => obj.ProcessPayment(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<double>()));

            mockCustomer.Setup(
                obj => obj.UpdateCustomerOrder(It.IsAny<string>(), It.IsAny<string>()));

            mockNotifier.Setup(
                obj => obj.SendReceipt(It.IsAny<OrderInfo>()));

            mockLogger.Setup(
                obj => obj.Log(It.IsAny<string>()));

            Commerce commerce = new Commerce(mockBilling.Object,
                                             mockCustomer.Object,
                                             mockNotifier.Object,
                                             mockLogger.Object);

            commerce.ProcessOrder(new OrderInfo());

            Assert.IsTrue(1 == 1); // this test just asserts that ProcessOrder can be called without error
        }
    }
}

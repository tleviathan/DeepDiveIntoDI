using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DI.MVC;
using DI.MVC.Controllers;
using System.Web.Mvc;

namespace DI.MEF.Tests
{
    [TestClass]
    public class MVCTests
    {
        public class TestCustomerRepository : ICustomerRepository
        {
            Customer ICustomerRepository.GetById(int id)
            {
                return new Customer();
            }

            List<Customer> ICustomerRepository.GetAll()
            {
                return new List<Customer>() { new Customer() };
            }

            void ICustomerRepository.Update(Customer customer)
            {
            }
        }

        [TestMethod]
        public void test_customers_action_for_correct_view()
        {
            HomeController controller = new HomeController(new TestCustomerRepository());
            ActionResult result = controller.Customers();
            ViewResult viewResult = result as ViewResult;

            Assert.IsTrue(viewResult != null);
            Assert.IsTrue(viewResult.Model is IEnumerable<Customer>);
        }
    }
}

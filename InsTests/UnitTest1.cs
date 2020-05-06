using System;
using InsMorning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();

            customer2.lastName = "Scotty";
            customer2.EnrollmentDate = new DateTime(2012, 5, 22);

            customer1.lastName="Bobby";
            customer1.EnrollmentDate = new DateTime(2002, 8, 8);

            Console.WriteLine(customer1.lastName);
            Console.WriteLine(customer1.CustomerID);
            


        }
    }
}

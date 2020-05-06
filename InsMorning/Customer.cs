using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace InsMorning
{
    public class Customer
    {
       
        public string lastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public List<Customer> totalCustomers = new List<Customer>();
        public int YearsOfEnrolment
        {
            get
            {
                double totalTime = (DateTime.Now - EnrollmentDate).TotalDays / 365.24;
                return Convert.ToInt32(Math.Floor(totalTime));
                
            }
        }

        public int CustomerID
        {
            get
            {
                return RandomID(); 
            }
        }

        public Customer()
        {
            AddCustomerToList(this);
        }
         
        int RandomID()
        {
            Random rand = new Random();
            int custmerID = rand.Next(0, 999);
            return custmerID;
        }

        public void CelebrateCustomer(int numberOfYears)
        {
            if (numberOfYears>5)
            {
                Console.WriteLine("Thank you for being a GOLD member.");
            }
            else
            {
                Console.WriteLine("Thank you....");
            }
        }
        
        public void RemoveCustomerFromList(Customer customer)
        {
            totalCustomers.Remove(customer);
        }

        public void DisplayTotalCustomers()
        {
            Console.WriteLine(totalCustomers.Count);
        }
        public void AddCustomerToList(Customer customer)
        {
            totalCustomers.Add(customer);
        }

    }
}

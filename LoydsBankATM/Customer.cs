using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoydsBankATM
{
    public class Customer
    {
        private int customerId;
        private string customerFirstName;
        private string customerLastName;
        private string customerEmail;
        private string customerPhone;
        private string customerAddress;

        public Customer(int customerId, string customerFirstName, string customerLastName, string customerPhone, string customerAddress, string customerEmail)
        {
            this.customerId = customerId;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.customerPhone = customerPhone;
            this.customerAddress = customerAddress;
            this.customerEmail = customerEmail;
        }
        public Customer()
        {

        }

        public int GetCustomerId() { return customerId; }
        public string GetCustomerFirstName() {return customerFirstName;}
        public string GetCustomerLastName() {return customerLastName;}
        public string GetCustomerEmail() {return customerEmail;}
        public string GetCustomerPhone() {return customerPhone;}
        public string GetCustomerAddress() {return customerAddress;}

    }
}

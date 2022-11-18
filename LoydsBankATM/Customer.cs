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

        public Customer(int customerId, string customerFirstName, string customerLastName, string customerEmail, string customerPhone, string customerAddress)
        {
            this.customerId = customerId;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.customerEmail = customerEmail;
            this.customerPhone = customerPhone;
            this.customerAddress = customerAddress;
        }

        public int GetCustomerId() { return customerId; }
        public string GetCustomerFirstName() {return customerFirstName;}
        public string GetCustomerLastName() {return customerLastName;}
        public string GetCustomerEmail() {return customerEmail;}
        public string GetCustomerPhone() {return customerPhone;}
        public string GetCustomerAddress() {return customerAddress;}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                
                customer.Email = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetreiveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}

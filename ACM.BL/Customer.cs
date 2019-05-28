using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {
            
        }


        public Customer (int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerType { get; set; }

        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int CustomerId { get; private set; }



        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;
            return isValid;
        }

        public string Log() =>
               $"{CustomerId}: {FullName} Email: {Email} Status: {EntityState.ToString()}";

    }
}

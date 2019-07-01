using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DDDApplication.Domain.Entites
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

        public bool SpacialCustomer(Customer customer)
        {
            return customer.Active && DateTime.Now.Year - customer.RegistrationDate.Year >= 5;
        }
    }
}

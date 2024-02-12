using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    /// <summary>
    /// Represents a menu for the customer to attach their information to their order
    /// </summary>
    internal class AddCustomer
    {
        /// <summary>
        /// A unique id for each customer
        /// </summary>
        [Key]
        public int CustomerId { get; set; }

        /// <summary>
        /// Customers first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customers last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Customers phone number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}

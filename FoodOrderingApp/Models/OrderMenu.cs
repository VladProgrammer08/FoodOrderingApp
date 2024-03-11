using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    /// <summary>
    /// Represents a single ordering menu for affordable purchases.
    /// </summary>
    public class OrderMenu
    {
        /// <summary>
        /// The unique identifier for each food order
        /// </summary>
        [Key]
        public int OrderId { get; set; }

        /// <summary>
        /// Sets a value indicating whether the order includes a hamburger.
        /// </summary>
        public bool Hamburger { get; set; }

        /// <summary>
        /// Sets a value indicating whether the order includes a pizza.
        /// </summary>
        public bool Pizza { get; set; }

        /// <summary>
        /// Sets a value indicating whether the order includes a hot dog.
        /// </summary>
        public bool HotDog { get; set; }

        /// <summary>
        /// Sets a value indicating whether the order includes a soda.
        /// </summary>
        public bool Soda { get; set; }

        /// <summary>
        /// Sets a value indicating whether the order includes a coffee.
        /// </summary>
        public bool Coffee { get; set; }

        /// <summary>
        /// Sets a value indicating whether the order includes a tea.
        /// </summary>
        public bool Tea { get; set; }

        /// <summary>
        /// Sets the subtotal of the order, excluding tax.
        /// </summary>
        [DataType(DataType.Currency)]
        public double Subtotal { get; set; }

        /// <summary>
        /// Gets the tax amount of the order, calculated as 10% of the subtotal.
        /// </summary>
        [DataType(DataType.Currency)]
        public double Tax { get; set; }

        /// <summary>
        /// Gets the total amount of the order, including tax.
        /// </summary>
        [DataType(DataType.Currency)]
        public double OrderTotal { get; set; }


        /// <summary>
        /// Customers first name
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Customers phone number
        /// </summary>
        public required string PhoneNumber { get; set; }
    }
}

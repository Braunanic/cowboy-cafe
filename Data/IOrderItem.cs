using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface to represent every orderable Item
    /// </summary>
    public interface IOrderItem 
    {
        /// <summary>
        /// price of the item in USD
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Special instructions for the item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

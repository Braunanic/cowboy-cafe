using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class to represent an order.
    /// </summary>
    public class Order 
    {


        private List<IOrderItem> items;
        /// <summary>
        /// Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; }

        /// <summary>
        /// Total cost of the order (no tax)
        /// </summary>
        public double Subtotal => 0;

        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }
    }
}

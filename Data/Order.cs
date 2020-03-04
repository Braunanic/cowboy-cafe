using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class to represent an order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {


        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items 
        {
            get
            {
                return items;
            }
        }
        /// <summary>
        /// Number of the Order being taken.
        /// </summary>
        public uint OrderNumber { get; } = 1;

        /// <summary>
        /// Total cost of the order (no tax)
        /// </summary>
        public double Subtotal 
        {
            get
            {
                double total= 0;
                if (items.Count > 0)
                {
                    foreach (IOrderItem i in items)
                    {
                        total += i.Price;
                    }
                }
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                return total;
            }
        }

        /// <summary>
        /// PropertyChanged Event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to Add an item to the List of Items
        /// </summary>
        /// <param name="item">item being added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// Method to Remove an item from the List of Items 
        /// </summary>
        /// <param name="item">item being removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}

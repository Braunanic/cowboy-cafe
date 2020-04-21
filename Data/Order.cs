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
                return items.ToArray();
            }
        }
        /// <summary>
        /// Number of the Order being taken.
        /// </summary>
        public static uint OrderNumber { get; set; } = 1;

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
               
                return total;
            }
        }

        /// <summary>
        /// Returns Total with 16% sales tax factored in
        /// </summary>
        public double Total
        {
            get { return Subtotal +(Subtotal * 0.16); }
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
            if (item is INotifyPropertyChanged notifier)
                notifier.PropertyChanged += OnItemPropertyChanged;
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Method to Remove an item from the List of Items 
        /// </summary>
        /// <param name="item">item being removed</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
                notifier.PropertyChanged -= OnItemPropertyChanged;
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// method to notify when a property is changed
        /// </summary>
        /// <param name="sender">object sending notifications</param>
        /// <param name="e">property being changed</param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}

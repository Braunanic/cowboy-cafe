/*
* Author: Nick Braun
* Class: Entree.cs
* Purpose: Base Class for entrees for cowboy cafe
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class from which all entrees will inherit. 
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Will represent the price of the entree.
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Will represent the Calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Will represent any special preparation instructions for the entree.
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}

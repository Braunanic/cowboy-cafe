/*
* Author: Nick Braun
* Class: Drink.cs
* Purpose: Base Class for Drinks for cowboy cafe
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Will represent the size of the drink
        /// </summary>
        public virtual Size Size 
        { 
            get { return size; } 
            set { 
                size = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            } }
        /// <summary>
        /// Will represent the price of the drink.
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Will represent the Calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }

        private bool ice = true;
        /// <summary>
        /// will represent whether the drink is served with ice.
        /// </summary>
        public bool Ice { get { return ice; } set { ice = value; NotifyOfPropertyChange("Ice"); } }
        /// <summary>
        /// Will represent any special preparation instructions for the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}

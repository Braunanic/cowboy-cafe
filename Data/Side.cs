/*
* Author: Nathan Bean
* Edited By: Nick Braun
* Class: Side.cs
* Purpose: Base abstract class for sides in Cowboy Cafe Project.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem , INotifyPropertyChanged
    {

        private Size size;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size 
        { 
            get { return size; } 
            set { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            } 
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Provides any special instructions
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

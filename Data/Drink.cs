/*
* Author: Nick Braun
* Class: Drink.cs
* Purpose: Base Class for Drinks for cowboy cafe
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Will represent the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Will represent the price of the drink.
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Will represent the Calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// will represent whether the drink is served with ice.
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Will represent any special preparation instructions for the drink.
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

    }
}

/*
* Author: Nick Braun
* Class: Entree.cs
* Purpose: Base Class for entrees for cowboy cafe
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class from which all entrees will inherit. 
    /// </summary>
    public abstract class Entree : IOrderItem
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
    }
}

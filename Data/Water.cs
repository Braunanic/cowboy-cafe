/*
* Author: Nick Braun
* Class: Water.cs
* Purpose: A Class Representing the Water Drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Class Representing the Water Drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// The price of the Water.
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }
        /// <summary>
        /// The calories of water.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// if the Water has a lemon slice.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Special instructions for the preparation of the water.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Lemon) { instructions.Add("add lemon"); }
                if (!Ice) { instructions.Add("hold ice"); }
                return instructions;
            }
        }
    }
}

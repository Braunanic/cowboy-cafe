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
        private bool lemon = false;
        /// <summary>
        /// if the Water has a lemon slice.
        /// </summary>
        public bool Lemon { get { return lemon; } set { lemon = value; NotifyOfPropertyChange("Lemon"); } }

        /// <summary>
        /// Special instructions for the preparation of the water.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Lemon) { instructions.Add("Add Lemon"); }
                if (!Ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Water</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small: return "Small Water";
                case Size.Medium: return "Medium Water";
                case Size.Large: return "Large Water";
                default: throw new NotImplementedException();
            }
        }
    }
}

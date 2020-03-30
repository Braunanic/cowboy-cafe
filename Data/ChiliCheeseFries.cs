/*
* Author: Nick Braun
* Class: ChiliCheeseFries.cs
* Purpose: A Class Representing the Chili Cheese Fries Side
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Will represent the ChiliCheese Fries Side.
    /// </summary>
    public class ChiliCheeseFries: Side
    {
        /// <summary>
        /// will represent the price of the chili Cheese fries.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.99;
                    case Size.Medium: return 2.99;
                    case Size.Large: return 3.99;
                    default: throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// will represent the calories of the chili Cheese fries.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 433;
                    case Size.Medium: return 524;
                    case Size.Large: return 610;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Chili Cheese Fries</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small: return "Small Chili Cheese Fries";
                case Size.Medium: return "Medium Chili Cheese Fries";
                case Size.Large: return "Large Chili Cheese Fries";
                default: throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Provides special instructions (none for sides)
        /// </summary>
        public override List<string> SpecialInstructions { get; }
    }
}

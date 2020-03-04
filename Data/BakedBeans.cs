/*
* Author: Nick Braun
* Class: BakedBeans.cs
* Purpose: A Class Representing the Baked Beans Side
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Will represent the Baked Beans Side.
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// will represent the price of the Baked Beans.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.59;
                    case Size.Medium: return 1.79;
                    case Size.Large: return 1.99;
                    default: throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// will represent the calories of the Baked Beans.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 312;
                    case Size.Medium: return 378;
                    case Size.Large: return 410;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Baked Beans</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small: return "Small Baked Beans";
                case Size.Medium: return "Medium Baked Beans";
                case Size.Large: return "Large Baked Beans";
                default: throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Provides special instructions (none for sides)
        /// </summary>
        public override IEnumerable<string> SpecialInstructions { get; }
    }
}

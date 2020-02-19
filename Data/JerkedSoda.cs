/*
* Author: Nick Braun
* Class: JerkedSoda.cs
* Purpose: A Class Representing the Jerked Soda Drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the jerked soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The price of the Jerked Soda.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.59;
                    case Size.Medium: return 2.10;
                    case Size.Large: return 2.59;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calorie count of the Jerked Soda.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 110;
                    case Size.Medium: return 146;
                    case Size.Large: return 198;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// falvor of soda.
        /// </summary>
        public SodaFlavor Flavor { get; set; } 

        /// <summary>
        /// Specials instructions for preparation of jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }
    }
}


/*
* Author: Nick Braun
* Class: RustlersRibs.cs
* Purpose: A Class Representing the Rustlers Ribs entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the Rustlers Ribs entree.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// The calorie count of the Rustler's Ribs entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Rustler's Ribs</returns>
        public override string ToString()
        {
            return "Rustlers Ribs";
        }
    }
}

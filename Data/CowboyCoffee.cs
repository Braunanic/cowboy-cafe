﻿/*
* Author: Nick Braun
* Class: CowboyCoffee.cs
* Purpose: A Class Representing the Cowboy Coffee Drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class to represent the cowboy coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The price of the Cowboy Coffee.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.60;
                    case Size.Medium: return 1.10;
                    case Size.Large: return 1.60;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calorie count of the Cowboy Coffee.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 3;
                    case Size.Medium: return 5;
                    case Size.Large: return 7;
                    default: throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// if the Coffee has room for cremae.
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// if the Coffee is decaf.
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// whether the coffee has ice
        /// </summary>
        new public bool Ice {get; set;} = false;
        /// <summary>
        /// Specials instructions for preparation of coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) { instructions.Add("Add Ice"); }
                if (RoomForCream) { instructions.Add("Room for Cream"); }
                //if (Decaf) { instructions.Add("Decaf"); }
                return instructions;
            }
        }
    }
}

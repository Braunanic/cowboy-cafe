/*
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
        private bool cream = false;
        /// <summary>
        /// if the Coffee has room for cremae.
        /// </summary>
        public bool RoomForCream { get { return cream; } set { cream = value; NotifyOfPropertyChange("RoomForCream"); } }

        private bool decaf;
        /// <summary>
        /// if the Coffee is decaf.
        /// </summary>
        public bool Decaf { get { return decaf; } set { decaf = value; NotifyOfPropertyChange("Decaf"); } }

        private bool ice = false;
        /// <summary>
        /// whether the coffee has ice
        /// </summary>
        new public bool Ice { get { return ice; } set { ice = value; NotifyOfPropertyChange("Ice"); } }
        /// <summary>
        /// Specials instructions for preparation of coffee
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
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

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Cowboy Coffee</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                switch (Size)
                {
                    case Size.Small: return "Small Decaf Cowboy Coffee";
                    case Size.Medium: return "Medium Decaf Cowboy Coffee";
                    case Size.Large: return "Large Decaf Cowboy Coffee";
                    default: throw new NotImplementedException();
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Small: return "Small Cowboy Coffee";
                    case Size.Medium: return "Medium Cowboy Coffee";
                    case Size.Large: return "Large Cowboy Coffee";
                    default: throw new NotImplementedException();
                }
            }
        }
    }
}

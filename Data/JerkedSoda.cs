﻿/*
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

        private SodaFlavor flavor;
        /// <summary>
        /// falvor of soda.
        /// </summary>
        public SodaFlavor Flavor { get { return flavor; } set { flavor = value; NotifyOfPropertyChange("Flavor"); } } 

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

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Jerked Soda</returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    switch (Size)
                    {
                        case Size.Small: return "Small Birch Beer Jerked Soda";
                        case Size.Medium: return "Medium Birch Beer Jerked Soda";
                        case Size.Large: return "Large Birch Beer Jerked Soda";
                        default: throw new NotImplementedException();
                    }
                case SodaFlavor.CreamSoda:
                    switch (Size)
                    {
                        case Size.Small: return "Small Cream Soda Jerked Soda";
                        case Size.Medium: return "Medium Cream Soda Jerked Soda";
                        case Size.Large: return "Large Cream Soda Jerked Soda";
                        default: throw new NotImplementedException();
                    }
                case SodaFlavor.OrangeSoda:
                    switch (Size)
                    {
                        case Size.Small: return "Small Orange Soda Jerked Soda";
                        case Size.Medium: return "Medium Orange Soda Jerked Soda";
                        case Size.Large: return "Large Orange Soda Jerked Soda";
                        default: throw new NotImplementedException();
                    }
                case SodaFlavor.RootBeer:
                    switch (Size)
                    {
                        case Size.Small: return "Small Root Beer Jerked Soda";
                        case Size.Medium: return "Medium Root Beer Jerked Soda";
                        case Size.Large: return "Large Root Beer Jerked Soda";
                        default: throw new NotImplementedException();
                    }
                case SodaFlavor.Sarsparilla:
                    switch (Size)
                    {
                        case Size.Small: return "Small Sarsparilla Jerked Soda";
                        case Size.Medium: return "Medium Sarsparilla Jerked Soda";
                        case Size.Large: return "Large Sarsparilla Jerked Soda";
                        default: throw new NotImplementedException();
                    }
                default: throw new NotImplementedException();
            }
            
        }
    }
}

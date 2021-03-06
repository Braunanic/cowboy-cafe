﻿/*
* Author: Nick Braun
* Class: TexasTea.cs
* Purpose: A Class Representing the Texas Tea Drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class to represent the texas tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// The price of the Texas Tea.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.00;
                    case Size.Medium: return 1.50;
                    case Size.Large: return 2.00;
                    default: throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// The calorie count of the Texas Tea.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:if (Sweet) return 10;
                                    else return 10 / 2;
                    case Size.Medium: if (Sweet) return 22;
                                         return 22 / 2;
                    case Size.Large: if (Sweet) return 36;
                                         return 36 / 2;
                    default: throw new NotImplementedException();
                }
            }
        }

        private bool sweet = true;
        /// <summary>
        /// if the Texas Tea has sweetener.
        /// </summary>
        public bool Sweet { get { return sweet; } set { sweet = value; NotifyOfPropertyChange("Sweet"); } }

        private bool lemon = false;
        /// <summary>
        /// if the Texas Tea has a lemon slice.
        /// </summary>
        public bool Lemon { get { return lemon; } set { lemon = value; NotifyOfPropertyChange("Lemon"); } }
        /// <summary>
        /// Special instructions for the preparation of the Tea.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Lemon) { instructions.Add("Add Lemon"); }
                //if (!Sweet) { instructions.Add("hold sweetener"); }
                if (!Ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Texas Tea</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                switch (Size)
                {
                    case Size.Small: return "Small Texas Sweet Tea";
                    case Size.Medium: return "Medium Texas Sweet Tea";
                    case Size.Large: return "Large Texas Sweet Tea";
                    default: throw new NotImplementedException();
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Small: return "Small Texas Plain Tea";
                    case Size.Medium: return "Medium Texas Plain Tea";
                    case Size.Large: return "Large Texas Plain Tea";
                    default: throw new NotImplementedException();
                }
            }
        }
    }
}

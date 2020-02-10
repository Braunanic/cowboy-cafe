/*
* Author: Nick Braun
* Class: PanDe.cs
* Purpose: A Class Representing the Chili Cheese Fries Side
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Will represent the Pan De Campo Side.
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// will represent the price of the Pan De Campo.
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
        /// will represent the calories of the Pan De Campo.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 227;
                    case Size.Medium: return 269;
                    case Size.Large: return 367;
                    default: throw new NotImplementedException();
                }
            }
        }

    }
}

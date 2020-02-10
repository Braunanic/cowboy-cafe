/*
* Author: Nick Braun
* Class: DakotaDoubleBurger.cs
* Purpose: A Class Representing the Dakota Double Entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class represening the Dakota Double Burger.
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// The price of the Dakota Double Burger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// The calorie count of the Dakota Double Burger.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }
        private bool cheese = true;
        /// <summary>
        /// If the Dakota Double is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        /// <summary>
        /// If the Dakota Double has mustard on it.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// if the Dakota Double has pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// if the Dakota Double has Ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// If the Dakota Double has tomato on it.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// if the Dakota Double has mayo.
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// if the Dakota Double has lettuce.
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger.
        /// </summary>
        /// /// <summary>
        /// if the Dakota Double has Bun
        /// </summary>
        public bool Bun { get; set; } = true;
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                if (!Bun) { instructions.Add("hold bun"); }
                return instructions;
            }
        }
    }
}

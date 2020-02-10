/*
* Author: Nick Braun
* Class: TexasTripleBurger.cs
* Purpose: A Class Representing the Texas Triple entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger.
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// The price of the Texas Triple Burger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }
        /// <summary>
        /// The calorie count of the Texas Triple Burger.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }
        private bool cheese = true;
        /// <summary>
        /// If the Texas Triple is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        /// <summary>
        /// If the Texas Triple has mustard on it.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// if the Texas Triple has pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// if the Texas Triple has Ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// If the Texas Triple has tomato on it.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// if the Texas Triple has mayo.
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// if the Texas Triple has lettuce.
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// if the Texas Triple has bacon.
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// if the Texas Triple has Egg.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// if the Texas Triple has Bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Special instructions for the preparation of the Texas Triple Burger.
        /// </summary>
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
                if (!Bacon) { instructions.Add("hold bacon"); }
                if (!Egg) { instructions.Add("hold egg"); }
                if (!Bun) { instructions.Add("hold bun"); }
                return instructions;
            }
        }
    }
}

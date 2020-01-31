using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the TrailBurger entree.
    /// </summary>
    public class TrailBurger
    {

        /// <summary>
        /// The price of TrailBurger.
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// The calorie count of TrailBurger.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }
        private bool cheese = true;
        /// <summary>
        /// If the TrailBurger is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        /// <summary>
        /// If the TrailBurger has mustard on it.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// if the TrailBurger has pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// if the TrailBurger has Ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// if the TrailBurger has Bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the TrailBurger.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Bun) { instructions.Add("hold bun"); }
                return instructions;
            }
        }
    }
}

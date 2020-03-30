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
            set { cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the Texas Triple has mustard on it.
        /// </summary>
        public bool Mustard { get { return mustard; } set { mustard = value; NotifyOfPropertyChange("Mustard"); } }

        private bool pickle = true;
        /// <summary>
        /// if the Texas Triple has pickles.
        /// </summary>
        public bool Pickle { get { return pickle; } set { pickle = value; NotifyOfPropertyChange("Pickle"); } }

        private bool ketchup = true;
        /// <summary>
        /// if the Texas Triple has Ketchup.
        /// </summary>
        public bool Ketchup { get { return ketchup; } set { ketchup = value; NotifyOfPropertyChange("Ketchup"); } }

        private bool tomato = true;
        /// <summary>
        /// If the Texas Triple has tomato on it.
        /// </summary>
        public bool Tomato { get { return tomato; } set { tomato = value; NotifyOfPropertyChange("Tomato"); } }

        private bool mayo = true;
        /// <summary>
        /// if the Texas Triple has mayo.
        /// </summary>
        public bool Mayo { get { return mayo; } set { mayo = value; NotifyOfPropertyChange("Mayo"); } }

        private bool lettuce = true;
        /// <summary>
        /// if the Texas Triple has lettuce.
        /// </summary>
        public bool Lettuce { get { return lettuce; } set { lettuce = value; NotifyOfPropertyChange("Lettuce"); } }

        private bool bacon = true;
        /// <summary>
        /// if the Texas Triple has bacon.
        /// </summary>
        public bool Bacon { get { return bacon; } set { bacon = value; NotifyOfPropertyChange("Bacon"); } }

        private bool egg = true;
        /// <summary>
        /// if the Texas Triple has Egg.
        /// </summary>
        public bool Egg { get { return egg; } set{egg = value; NotifyOfPropertyChange("Egg"); } } 

        private bool bun = true;
        /// <summary>
        /// if the Texas Triple has Bun
        /// </summary>
        public bool Bun { get { return bun; } set { bun = value; NotifyOfPropertyChange("Bun"); } }
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

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Texas Triple Burger</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}

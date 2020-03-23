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
            set { cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }
        private bool mustard = true;
        /// <summary>
        /// If the Dakota Double has mustard on it.
        /// </summary>
        public bool Mustard { get { return mustard; } set {mustard = value; NotifyOfPropertyChange("Mustard"); } }

        private bool pickle = true;
        /// <summary>
        /// if the Dakota Double has pickles.
        /// </summary>
        public bool Pickle { get { return pickle; } set {pickle = value; NotifyOfPropertyChange("Pickle"); } }

        private bool ketchup = true;
        /// <summary>
        /// if the Dakota Double has Ketchup.
        /// </summary>
        public bool Ketchup { get { return ketchup; } set { ketchup = value; NotifyOfPropertyChange("Ketchup"); } }

        private bool tomato = true;
        /// <summary>
        /// If the Dakota Double has tomato on it.
        /// </summary>
        public bool Tomato { get { return tomato; } set { tomato = value; NotifyOfPropertyChange("Tomato"); } }

        private bool mayo = true;
        /// <summary>
        /// if the Dakota Double has mayo.
        /// </summary>
        public bool Mayo { get { return mayo; } set { mayo = value; NotifyOfPropertyChange("Mayo"); } }

        private bool lettuce = true;
        /// <summary>
        /// if the Dakota Double has lettuce.
        /// </summary>
        public bool Lettuce { get { return lettuce; } set { lettuce = value; NotifyOfPropertyChange("Lettuce"); } }
        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger.
        /// </summary>
        /// 
        private bool bun = true;
        /// /// <summary>
        /// if the Dakota Double has Bun
        /// </summary>
        public bool Bun { get { return bun; } set { bun = value; NotifyOfPropertyChange("Bun"); } }
        /// <summary>
        /// instructions for preparation
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
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

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Dakota Double Burger</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}

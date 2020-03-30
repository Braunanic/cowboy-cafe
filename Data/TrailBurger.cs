/*
* Author: Nick Braun
* Class: TrialBurger.cs
* Purpose: A Class Representing the Trail Burger Entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the TrailBurger entree.
    /// </summary>
    public class TrailBurger : Entree
    {

        /// <summary>
        /// The price of TrailBurger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// The calorie count of TrailBurger.
        /// </summary>
        public override uint Calories
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
            set { cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the TrailBurger has mustard on it.
        /// </summary>
        public bool Mustard 
         {
                get { return mustard; }
                set { mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
         }

        private bool pickle = true;
        /// <summary>
        /// if the TrailBurger has pickles.
        /// </summary>
        public bool Pickle 
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// if the TrailBurger has Ketchup.
        /// </summary>
        public bool Ketchup { get { return ketchup; } set { ketchup = value; NotifyOfPropertyChange("Ketchup"); } }

        private bool bun = true;
        /// <summary>
        /// if the TrailBurger has Bun
        /// </summary>
        public bool Bun { get { return bun; } set { bun = value; NotifyOfPropertyChange("Bun"); } }

        /// <summary>
        /// Special instructions for the preparation of the TrailBurger.
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
                if (!Bun) { instructions.Add("hold bun"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing TrailBurger</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}

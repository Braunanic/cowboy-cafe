/*
* Author: Nick Braun
* Class: AngryChicken.cs
* Purpose: A class representing the Angry Chicken Entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Angry Chicken entree.
    /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// The price of the Angry Chicken sandwich.
        /// </summary>
        public override  double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// The calorie count of the Angry Chicken sandwich.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the sandwich comes with pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// If the sandwich has bread.
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the sandwich.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Bread) { instructions.Add("hold bread"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of this object
        /// </summary>
        /// <returns>string describing Angry Chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }


    }
}

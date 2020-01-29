using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Peco's Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// The price of Peco's Pulled Pork.
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// The calorie count of Peco's Pulled Pork.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }
        private bool pickle = true;
        /// <summary>
        /// If the pork comes with pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// If the pork has bread.
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the pork.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Bread) { instructions.Add("hold bread"); }
                return instructions;
            }
        }
    }
}

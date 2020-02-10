﻿/*
* Author: Nick Braun
* Class: COrn Dodgers.cs
* Purpose: A Class Representing the Corn Dodgers Side
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Corn Dodgers side
    /// </summary>
    public class CornDodgers : Side
    {
        
            /// <summary>
            /// will represent the price of the Corn Dodgers
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
            /// will represent the calories of the Corn Dodgers.
            /// </summary>
            public override uint Calories
            {
                get
                {
                    switch (Size)
                    {
                        case Size.Small: return 512;
                        case Size.Medium: return 685;
                        case Size.Large: return 717;
                        default: throw new NotImplementedException();
                    }
                }
            }
        }
    }


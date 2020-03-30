using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var item = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Cheese = false;
            });
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Mustard", () => {
                item.Mustard = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Mustard = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Pickle", () => {
                item.Pickle = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Pickle = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Ketchup", () => {
                item.Ketchup = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Ketchup = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Tomato", () => {
                item.Tomato = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Tomato = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Mayo", () => {
                item.Mayo = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Mayo = false;
            });
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Lettuce", () => {
                item.Lettuce = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Lettuce = false;
            });
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Bun", () => {
                item.Bun = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Bun = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Egg", () => {
                item.Egg = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Egg = false;
            });
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Bacon", () => {
                item.Bacon = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Bacon = false;
            });
        }
    }
}

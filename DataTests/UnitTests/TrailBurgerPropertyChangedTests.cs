using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void TrailBurgerImplementsINotifyPropertyChanged()
        {
            var item = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Cheese", () => {
                item.Cheese = false;
            });
        }
        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TrailBurger();
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
            var item = new TrailBurger();
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
            var item = new TrailBurger();
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
            var item = new TrailBurger();
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
            var item = new TrailBurger();
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
            var item = new TrailBurger();
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
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Ketchup = false;
            });
        }



        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var item = new TrailBurger();
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
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Bun = false;
            });
        }

    }
}

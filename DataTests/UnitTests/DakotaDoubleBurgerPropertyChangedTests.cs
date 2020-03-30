using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void DakotaDoubleBurgerImplementsINotifyPropertyChanged()
        {
            var item = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Bun = false;
            });
        }
    }
}

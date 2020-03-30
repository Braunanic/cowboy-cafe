using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void CowboyCoffeeImplementsINotifyPropertyChanged()
        {
            var item = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Size", () => {
                item.Size = Size.Large;
            });
            Assert.PropertyChanged(item, "Size", () => {
                item.Size = Size.Medium;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingPricePropertyShouldInvokePropertyChangedForSize()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Price", () => {
                item.Size = Size.Large;
            });
            Assert.PropertyChanged(item, "Price", () => {
                item.Size = Size.Medium;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingCaloriesPropertyShouldInvokePropertyChangedForSize()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Calories", () => {
                item.Size = Size.Large;
            });
            Assert.PropertyChanged(item, "Calories", () => {
                item.Size = Size.Medium;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "RoomForCream", () => {
                item.RoomForCream = true;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.RoomForCream = true;
            });
        }



        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Ice", () => {
                item.Ice = true;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Ice = true;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Decaf", () => {
                item.Decaf = true;
            });
        }


    }
}

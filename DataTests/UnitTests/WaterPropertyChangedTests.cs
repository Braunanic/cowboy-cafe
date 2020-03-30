using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class WaterPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var item = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var item = new Water();
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
            var item = new Water();
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
            var item = new Water();
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
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var item = new Water();
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
            var item = new Water();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Ice = true;
            });
        }
    }
}

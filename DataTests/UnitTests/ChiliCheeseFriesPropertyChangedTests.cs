using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var side = new ChiliCheeseFries();
            Assert.PropertyChanged(side, "Size", () => {
                side.Size = Size.Large;
            });
            Assert.PropertyChanged(side, "Size", () => {
                side.Size = Size.Medium;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var side = new ChiliCheeseFries();
            Assert.PropertyChanged(side, "Price", () => {
                side.Size = Size.Large;
            });
            Assert.PropertyChanged(side, "Price", () => {
                side.Size = Size.Medium;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var side = new ChiliCheeseFries();
            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Large;
            });
            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Medium;
            });
        }
    }
}

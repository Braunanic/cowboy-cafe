using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class CornDodgersPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void CornDodgersFriesImplementsINotifyPropertyChanged()
        {
            var side = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var side = new CornDodgers();
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
            var side = new CornDodgers();
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
            var side = new CornDodgers();
            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Large;
            });
            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Medium;
            });
        }
    }
}

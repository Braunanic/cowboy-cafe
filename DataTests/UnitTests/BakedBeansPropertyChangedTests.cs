using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;
namespace CowboyCafe.DataTests
{
    public class BakedBeansPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var side = new BakedBeans();
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
            var side = new BakedBeans();
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
            var side = new BakedBeans();
            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Large;
            });
            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Medium;
            });
        }
    }
}

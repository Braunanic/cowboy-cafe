using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class JerkedSodaPropertyChanged
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void CowboyCoffeeImplementsINotifyPropertyChanged()
        {
            var item = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var item = new JerkedSoda();
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
            var item = new JerkedSoda();
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
            var item = new JerkedSoda();
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
            var item = new JerkedSoda();
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
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Ice = true;
            });
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChangedForFlavor()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Flavor", () => {
                item.Flavor = SodaFlavor.CreamSoda;
            });
            Assert.PropertyChanged(item, "Flavor", () => {
                item.Flavor = SodaFlavor.BirchBeer;
            });
            Assert.PropertyChanged(item, "Flavor", () => {
                item.Flavor = SodaFlavor.RootBeer;
            });
            Assert.PropertyChanged(item, "Flavor", () => {
                item.Flavor = SodaFlavor.Sarsparilla;
            });
            Assert.PropertyChanged(item, "Flavor", () => {
                item.Flavor = SodaFlavor.OrangeSoda;
            });
        }
    }
}

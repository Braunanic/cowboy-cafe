using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void CowpokechiliImplementsINotifyPropertyChanged()
        {
            var item = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var item = new CowpokeChili();
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
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Cheese = false;
            });
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SourCream", () => {
                item.SourCream = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.SourCream = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "GreenOnions", () => {
                item.GreenOnions = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.GreenOnions = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "TortillaStrips", () => {
                item.TortillaStrips = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.TortillaStrips = false;
            });
        }
    }
}

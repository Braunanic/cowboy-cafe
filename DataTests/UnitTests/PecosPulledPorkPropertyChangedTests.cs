using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var item = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var item = new PecosPulledPork();
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
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Pickle = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "Bread", () => {
                item.Bread = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Bread = false;
            });
        }
    }
}

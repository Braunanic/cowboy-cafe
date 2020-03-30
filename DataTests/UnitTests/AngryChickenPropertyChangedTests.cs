using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void AngryChickenImplementsINotifyPropertyChanged()
        {
        var chicken = new AngryChicken();
        Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () => {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () => {
                chicken.Pickle = false;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => {
                chicken.Pickle = false;
            });
        }
    }
}

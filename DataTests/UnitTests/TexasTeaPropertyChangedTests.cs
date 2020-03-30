using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TexasTeaPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var item = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var item = new TexasTea();
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
            var item = new TexasTea();
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
            var item = new TexasTea();
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
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Lemon", () => {
                item.Lemon = true;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Lemon = true;
            });
        }


        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var item = new TexasTea();
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
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Ice = true;
            });
        }

        /// <summary>
        /// Testing that Inotify is invoked when this property is changed.
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Sweet", () => {
                item.Sweet = true;
            });
        }
    }
}

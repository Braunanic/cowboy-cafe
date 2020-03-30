using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;
namespace CowboyCafe.DataTests
{
    public class RustlersRibsPropertyChangedTests
    {
        /// <summary>
        /// Testing that the Order Item implements InotifyPropertychanged properly
        /// </summary>
        [Fact]
        public void RustlersRibsImplementsINotifyPropertyChanged()
        {
            var item = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
    }
}

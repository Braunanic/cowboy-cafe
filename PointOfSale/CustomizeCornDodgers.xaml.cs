using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCornDodgers.xaml
    /// </summary>
    public partial class CustomizeCornDodgers : UserControl
    {
        public CustomizeCornDodgers()
        {
            InitializeComponent();
            SmallButton.Click += SmallButton_Click;
            MediumButton.Click += MediumButton_Click;
            LargeButton.Click += LargeButton_Click;
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            ((Side)DataContext).Size = CowboyCafe.Data.Size.Small;
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            ((Side)DataContext).Size = CowboyCafe.Data.Size.Medium;
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            ((Side)DataContext).Size = CowboyCafe.Data.Size.Large;
        }
    }
}

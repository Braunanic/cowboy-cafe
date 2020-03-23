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
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        public CustomizeJerkedSoda()
        {
            InitializeComponent(); 
            SmallButton.Click += SmallButton_Click;
            MediumButton.Click += MediumButton_Click;
            LargeButton.Click += LargeButton_Click;
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            ((Drink)DataContext).Size = CowboyCafe.Data.Size.Small;
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            ((Drink)DataContext).Size = CowboyCafe.Data.Size.Medium;
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            ((Drink)DataContext).Size = CowboyCafe.Data.Size.Large;
        }

        private void OrangeButton_Click(object sender, RoutedEventArgs e)
        {
            ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
        }

        private void CreamButton_Click(object sender, RoutedEventArgs e)
        {
            ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
        }

        private void SarsparillaButton_Click(object sender, RoutedEventArgs e)
        {
            ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;
        }

        private void RootButton_Click(object sender, RoutedEventArgs e)
        {
            ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
        }

        private void BirchButton_Click(object sender, RoutedEventArgs e)
        {
            ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
        }
    }
}

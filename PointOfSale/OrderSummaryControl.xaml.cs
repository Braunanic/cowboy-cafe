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
using Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
            OrderItemListBox.SelectionChanged += OnSelectedItem;
        }

        /// <summary>
        /// Selection Changed event for The Items List view
        /// </summary>
        /// <param name="sender">item clicked</param>
        /// <param name="e">event args</param>
        void OnSelectedItem(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var lvi = ((sender as ListView).SelectedItem as IOrderItem);
            if (this.DataContext is Order order)
            {
                var foodItem = (lvi);
                ;
                if (lvi is CowpokeChili)
                {
                  var   screen = new CustomizeCowpokeChili();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is AngryChicken)
                {
                   var  screen = new CustomizeAngryChicken();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is BakedBeans)
                {
                   var  screen = new CustomizeBakedBeans();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is ChiliCheeseFries)
                {
                   var  screen = new CustomizeChiliCheeseFries();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is CornDodgers)
                {
                   var  screen = new CustomizeCornDodgers();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is CowboyCoffee)
                {
                  var   screen = new CustomizeCowboyCoffee();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is DakotaDoubleBurger)
                {
                    var screen = new CustomizeDakotaDouble();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is JerkedSoda)
                {
                   var  screen = new CustomizeJerkedSoda();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is PanDeCampo)
                {
                   var  screen = new CustomizePanDeCampo();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is PecosPulledPork)
                {
                    var screen = new CustomizePecosPulledPork();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is TexasTea)
                {
                    var screen = new CustomizeTexasTea();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is TexasTripleBurger)
                {
                    var screen = new CustomizeTexasTriple();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is Water)
                {
                     var screen = new CustomizeWater();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
                else if (lvi is TrailBurger)
                {
                    var screen = new CustomizeTrailBurger();
                    screen.DataContext = foodItem;
                    orderControl.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click Event for remove Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            var order = (Order)this.DataContext;
            var lvi = (OrderItemListBox.SelectedItem as IOrderItem);
            if (lvi != null)
            {
                order.Remove(lvi);
            }
        }
    }
}

/*
* Author: Nick Braun
* Class: OrderControl.xaml.cs
* Purpose: A class representing the OrderControl GUI
*/
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

    ///For Data Binding: Bind Order Control to Order instance via dataconext = new Order();
    ///Bind children -> <ListView ItemsSource ="{Binding Path = Items}"/>
    ///                     <ListView.ItemsTemplate/>
    ///                     <DataTemplate>
    ///                     <Grid>
    ///                     <TextBox Text="{Binding Path=Subtotal, StringFormat=c}">
    ///                     </TextBox>
    ///                     </Grid>
    ///                     </DataTemplate>
    ///                     
    ///
    ///                 If (DataContext is Order order){
    ///                 order.Add(new CowpokeChili());                
    ///                     }
    ///                     Or
    ///                     Use NAmes of buttons to write one big switch statement for all
    ///                     buttons at the same time.
     

    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Contructor that initializes the components and events
        /// </summary>
        public OrderControl()
        {
           
            InitializeComponent();
            DataContext = new Order();
            OrderSumm = new OrderSummaryControl();
            itemSelectionButton.Click += OnItemSelectionClicked;
        }

        /// <summary>
        /// Method to swap screens between elements
        /// </summary>
        /// <param name="element">screen being swapped to</param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// Click Event for Item Selected Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Click Event for cancel Order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Click Event for Complete Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderClicked(object sender, RoutedEventArgs e)
        {
            Order.OrderNumber++;
            this.DataContext = new Order();
        }
        
    }
}

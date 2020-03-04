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
            itemSelectionButton.Click += OnItemSelectionClicked;
            cancelOrderButton.Click += OnCancelOrderClicked;
            completeOrderButton.Click += OnCompleteOrderClicked;
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        void OnItemSelectionClicked(object sender, RoutedEventArgs e)
        {

        }

        void OnCancelOrderClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnCompleteOrderClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
        
    }
}

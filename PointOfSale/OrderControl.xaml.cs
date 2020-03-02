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
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }
        /// <summary>
        /// Click Event for Cowpoke Chili Button
        /// </summary>
        /// <param name="sender">Button Being Clicked</param>
        /// <param name="e">Event Arguments being sent</param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }
        /// <summary>
        /// Click Event for TrailBurger Button
        /// </summary>
        /// <param name="sender">Button Being Clicked</param>
        /// <param name="e">Event Arguments being sent</param>
        void OnAddTrailBurgerClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }
        /// <summary>
        /// Click Event for Dakota Double Burger Button
        /// </summary>
        /// <param name="sender">Button Being Clicked</param>
        /// <param name="e">Event Arguments being sent</param>
        void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }
        /// <summary>
        /// Click Event for Pecos Pulled Pork Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Click Event for Texas Triple Burger Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">event arguments being sent</param>
        private void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Click Event for Angry Chicken Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }
        /// <summary>
        /// Click Event for Rustlers Ribs Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Click Event for Chili Cheese Fries Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Click Event for Corn Dodgers Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Click Event for Pan De Campo Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Click Event for Baked Beans Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Click Event for Jerked Soda Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Click Event for Texas Tea Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Click Event for CowboyCoffee Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Click Event for Water Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        private void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}

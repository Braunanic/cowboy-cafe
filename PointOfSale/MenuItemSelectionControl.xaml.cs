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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        public MenuItemSelectionControl()
        {
            InitializeComponent();
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
        public void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button)
                {
                    var entree = new CowpokeChili();
                    var screen = new CustomizeCowpokeChili();
                    screen.DataContext = entree;
                    order.Add(entree);
                    orderControl.SwapScreen(screen);
                }
            }
            //OrderListView.Items.Add(new CowpokeChili());
        }
        /// <summary>
        /// Click Event for TrailBurger Button
        /// </summary>
        /// <param name="sender">Button Being Clicked</param>
        /// <param name="e">Event Arguments being sent</param>
        public void OnAddTrailBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new TrailBurger());
        }
        /// <summary>
        /// Click Event for Dakota Double Burger Button
        /// </summary>
        /// <param name="sender">Button Being Clicked</param>
        /// <param name="e">Event Arguments being sent</param>
        public void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new DakotaDoubleBurger());
        }
        /// <summary>
        /// Click Event for Pecos Pulled Pork Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            
        }

        /// <summary>
        /// Click Event for Texas Triple Burger Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">event arguments being sent</param>
        public void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Click Event for Angry Chicken Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new AngryChicken());
        }
        /// <summary>
        /// Click Event for Rustlers Ribs Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Click Event for Chili Cheese Fries Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Click Event for Corn Dodgers Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Click Event for Pan De Campo Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Click Event for Baked Beans Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Click Event for Jerked Soda Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Click Event for Texas Tea Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Click Event for CowboyCoffee Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Click Event for Water Button
        /// </summary>
        /// <param name="sender">Button being clicked</param>
        /// <param name="e">evnet arguments being sent</param>
        public void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
                //orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
            //OrderListView.Items.Add(new Water());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// returns a list of all entrees on the menu
        /// </summary>
        public IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new AngryChicken());
            list.Add(new CowpokeChili());
            list.Add(new DakotaDoubleBurger());
            list.Add(new PecosPulledPork());
            list.Add(new TexasTripleBurger());
            list.Add(new TrailBurger());
            list.Add(new RustlersRibs());
            return list;
            
        }

        /// <summary>
        /// returns a list with all sides
        /// </summary>
        public IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BakedBeans());
            list.Add(new CornDodgers());
            list.Add(new ChiliCheeseFries());
            list.Add(new PanDeCampo());
            return list;

        }

        /// <summary>
        /// returns a list with all drinks
        /// </summary>
        public IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new CowboyCoffee());
            list.Add(new JerkedSoda());
            list.Add(new TexasTea());
            list.Add(new Water());
            return list;

        }

        /// <summary>
        /// returns a list of all items on the menu
        /// </summary>
        public IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new AngryChicken());
            list.Add(new CowpokeChili());
            list.Add(new DakotaDoubleBurger());
            list.Add(new PecosPulledPork());
            list.Add(new TexasTripleBurger());
            list.Add(new TrailBurger());
            list.Add(new BakedBeans());
            list.Add(new CornDodgers());
            list.Add(new ChiliCheeseFries());
            list.Add(new PanDeCampo());
            list.Add(new CowboyCoffee());
            list.Add(new JerkedSoda());
            list.Add(new TexasTea());
            list.Add(new Water());
            return list;

        }
    }
}

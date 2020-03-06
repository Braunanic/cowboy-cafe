using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Finds the first ancestor in the Visual Tree that has the specified type
        /// </summary>
        /// <typeparam name="T">type specified</typeparam>
        /// <param name="obj">object calling this method.</param>
        /// <returns>the first ancestor of the type T, or null</returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        { 
            var parent = VisualTreeHelper.GetParent(obj);
            if (parent is null){ return null; }
            if (parent is T) { return parent as T; }
            return FindAncestor<T>(parent);
        }
    }
}

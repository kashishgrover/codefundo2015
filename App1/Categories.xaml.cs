using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Categories : Page
    {
        public Categories()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += (s, a) =>
            {
                Debug.WriteLine("BackRequested");
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    a.Handled = true;
                }
            };
        }

        private void Electronics_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapView), null);
            Global.selCat = "Electronics";
        }

        private void Cleaning_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapView), null);
            Global.selCat = "Cleaning";
        }

        private void Writing_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapView), null);
            Global.selCat = "Writing";
        }

        private void Daily_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapView), null);
            Global.selCat = "Daily";
        }

        private void Misc_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapView), null);
            Global.selCat = "Misc";
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapView), null);
        }
    }
}

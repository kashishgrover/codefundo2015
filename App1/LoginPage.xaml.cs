using System;
using System.Diagnostics;
using Windows.UI.Popups;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 


    public sealed partial class LoginPage : Page
    {
        string id = "";
        string password = "";
        string name = "";

        public LoginPage()
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

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            id = textBox.Text;
            password = passwordBox.Password;
            
            if (id == "kashish" && password == "asdf")
                this.Frame.Navigate(typeof(MainPage), null);
            else
            {
                var dialog1 = new MessageDialog("Invalid!");
                await dialog1.ShowAsync();
            }
        }

        private async void RegButton_Click(object sender, RoutedEventArgs e)
        {
            name = RegNameBox.Text;
            id = RegIDBox.Text;
            password = RegPwdBox.Password.ToString();

            var dialog1 = new MessageDialog(name + id + password);
            await dialog1.ShowAsync();

            try
            {
                User item = new User
                {
                    name = name, id = id, password = password
                };

                await App.MobileService.GetTable<User>().InsertAsync(item);
                //add loading circle here
                var dialog2 = new MessageDialog("Registered!");
                await dialog2.ShowAsync();
            }
            catch(Exception)
            {
                var dialog3 = new MessageDialog(e.ToString());
                await dialog3.ShowAsync();
            }

        }
    }
}

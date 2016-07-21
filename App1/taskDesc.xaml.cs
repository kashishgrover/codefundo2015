using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    /// 

    public sealed partial class taskDesc : Page
    {
        string x = "";
        string y = "";
        
        public taskDesc()
        {
            this.InitializeComponent();
                        
        }
        
        private async void getcood_Click(object sender, RoutedEventArgs e)
        {
            var accessStatus = await Geolocator.RequestAccessAsync();
            switch (accessStatus)
            {
                case GeolocationAccessStatus.Allowed:
                    Geolocator gl = new Geolocator();
                    Geoposition gp = await gl.GetGeopositionAsync();
                    Geopoint myloc = gp.Coordinate.Point;
                    y = myloc.Position.Longitude.ToString("0.00");
                    x = myloc.Position.Latitude.ToString("0.00");
                    break;
                case GeolocationAccessStatus.Denied:
                    break;
                case GeolocationAccessStatus.Unspecified:
                    break;
            }
            locationBox.Text = x + "," + y;
            locationBox.IsReadOnly = true;
            locationBox.IsEnabled = false;
        }

        private async void submit_Click(object sender, RoutedEventArgs e)
        {
            String itemtitle = "";      //1
            String det = "";            //2
            String timest = "";         //3
            String timeen = "";         //4
            String timede = "";         //5
            String date1 = "";          //6
            String date2 = "";          //7
            String price = "";          //8
            String grp = "";            //9
            String lat = "";           //10
            String lon = "";           //10


            itemtitle = titleip.Text;               //1
            if (timespec.IsChecked == true)
            {
                timest = timestrtip.Time.ToString();
                timeen = timeenip.Time.ToString();
                date1 = date1ip.Date.ToString();        //4,3,6
            }
            else if (dlspec.IsChecked == true)
            {
                timede = timedeadip.Time.ToString();
                date2 = date2ip.Date.ToString();        //5,7
            }
            price = priceip.Text;           //8

            Details.Document.GetText(Windows.UI.Text.TextGetOptions.None, out det);         //2

            ComboBoxItem cbi = (ComboBoxItem)catsel.SelectedItem;
            try
            {
                grp = cbi.Content.ToString();   //9
            }
           catch(Exception)
            {
                var dialog = new MessageDialog("Select a Category!");
                await dialog.ShowAsync();
            }

            getcood_Click(sender, e);

            lat = x;      //10
            lon = y;     //10

            try
            {
                Service item = new Service
                {
                    id = price,
                    title = itemtitle,
                    details = det,
                    deadline = timede,
                    price = price,
                    category = grp,
                    lat = lat,
                    status = "pending",
                    doid = lat,
                    addid = lat,
                    lon = lon,
                    timest = timest,
                    timeen = timeen,
                    date1 = date1,
                    date2 = date2
                };

                await App.MobileService.GetTable<Service>().InsertAsync(item);
                //add loading circle here
                var dialog3 = new MessageDialog("Task Added!");
                await dialog3.ShowAsync();
            }
            catch (Exception)
            {
                var dialog3 = new MessageDialog(e.ToString());
                await dialog3.ShowAsync();
            }
            finally
            {
            var dialog2 = new MessageDialog(itemtitle + "\n" + det + "\n" + timest + "\n" + timeen
                                           + "\n" + timede + "\n" + date1 + "\n" + date2 + "\n" + price
                                           + "\n" + grp + "\n" + lat + "\n" + lon);
            await dialog2.ShowAsync();
            }

        }
    }
}

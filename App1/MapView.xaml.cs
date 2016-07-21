using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class MapView : Page
    {
        public MapView()
        {
            this.InitializeComponent();
        }

        string grp = Global.selCat;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                this.Frame.Navigate(typeof(sellerdesc), null);
                Global.tit = (String)listView.SelectedValue;
                var dialog6 = new MessageDialog(Global.tit +" was selected");
                await dialog6.ShowAsync();
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog(ex.ToString());
                await dialog.ShowAsync();
            }

        }
       

        private async void refresh_Click(object sender, RoutedEventArgs e)
        {

            
            var accessStatus = await Geolocator.RequestAccessAsync();
            switch (accessStatus)
            {
                case GeolocationAccessStatus.Allowed:
                    Geolocator gl = new Geolocator();
                    Geoposition gp = await gl.GetGeopositionAsync();
                    Geopoint myloc = gp.Coordinate.Point;
                    map1.Center = myloc;
                    map1.ZoomLevel = 10;
                    map1.LandmarksVisible = true;
                    MapIcon mi = new MapIcon();
                    mi.Location = myloc;
                    mi.Title = "current";
                    mi.NormalizedAnchorPoint = new Point(0.5, 1.0);
                    mi.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/pin.png"));
                    mi.ZIndex = 0;
                    map1.MapElements.Add(mi);
                    break;
                case GeolocationAccessStatus.Denied:
                    var dialog1 = new MessageDialog("Denied");
                    await dialog1.ShowAsync();
                    break;
                case GeolocationAccessStatus.Unspecified:
                    break;
                  }

            
           List<Service> s = await App.MobileService.GetTable<Service>().ToListAsync();

            double la, lo;

            foreach (Service i in s)
               {
                la = Convert.ToDouble(i.lat);
                lo = Convert.ToDouble(i.lon);

                // lat long
                Geopoint gps = new Geopoint(new BasicGeoposition() { Latitude = la, Longitude = lo });
                MapIcon mi1 = new MapIcon();
                mi1.Location = gps;
                mi1.Title = "qwer";
                mi1.NormalizedAnchorPoint = new Point(0.5, 1.0);
                mi1.ZIndex = 0;
                map1.MapElements.Add(mi1);
              }
            

            foreach (Service i in s)
            {
                if (i.category.Equals(Global.selCat))
                    listView.Items.Add(i.title);
            }
            
          }

        
    }
}

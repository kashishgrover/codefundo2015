using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
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
    public sealed partial class sellerdesc : Page
    {
        public sellerdesc()
        {
            this.InitializeComponent();
            this.bloop();
        }

        private async void bloop()
        {
            List<Service> s = await App.MobileService.GetTable<Service>().ToListAsync();
            String timest = "";
            String timend = "";
            String date1 = "";
            String date2 = "";
            String timedead1 = "";
            String price = "";
            String cat = "";
            String xcood = "";
            String ycood = "";

            foreach (Service i in s)
            {

                if (i.title.Equals(Global.tit))
                {
                    timest = i.timest;
                    timend = i.timest;
                    date1 = i.date1;
                    date2 = i.date2;
                    timedead1 = i.timest;
                    price = i.price;
                    cat = i.category;
                    titleop.Text = i.title;
                    det.Text = i.details;
                    timestart.Text= timest;
                    timeend.Text=timend;
                    timedead.Text = timedead1;
                    datespec.Text=date1;
                    datedead.Text=date2;
                    pricedisp.Text = price;
                    catselop.Text = cat;
                    xcood = i.lat;
                    ycood = i.lon;
                    locationBox.Text = xcood + "  " + ycood;
                    i.status = "done";
                    break;

                }
            }
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("go do your work now");
            await dialog.ShowAsync();
        }
    }
}

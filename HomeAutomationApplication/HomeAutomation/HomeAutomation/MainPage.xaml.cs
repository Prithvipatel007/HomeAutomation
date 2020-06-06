using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace HomeAutomation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Pages.HomePage()) { BarBackgroundColor = Color.LightGray};
            IsPresented = false;
        }

        private void LivingRoomButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.LivingRoom()) { BarBackgroundColor = Color.LightGray };
            IsPresented = false;
        }

        private void StudyRoomButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.StudyRoom()) { BarBackgroundColor = Color.LightGray };
            IsPresented = false;
        }

        private void KitchenButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Kitchen()) { BarBackgroundColor = Color.LightGray };
            IsPresented = false;
        }

        private void BedroomButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.BedRoom()) { BarBackgroundColor = Color.LightGray };
            IsPresented = false;
        }

        private void GardenButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Garden()) { BarBackgroundColor = Color.LightGray };
            IsPresented = false;
        }

        private void EntranceButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Entrance()) { BarBackgroundColor = Color.LightGray };
            IsPresented = false;
        }

        private void HomeButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.HomePage()) { BarBackgroundColor = Color.LightGray };
            IsPresented = false;
        }
    }
}

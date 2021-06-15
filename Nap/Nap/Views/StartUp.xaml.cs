
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartUp : ContentPage
    {
        public StartUp()
        {
            InitializeComponent();
            LT30Nap.Released += LT30Nap_ClickedAsync;
            Nap90.Released += Nap90_Clicked;
            CustomNap.Released += CustomNap_Clicked;
            LogandSettings.Released += Settings_Clicked;
        }

        private async void LT30Nap_ClickedAsync(object sender, EventArgs e)
        {
            await DisplayAlert ("20 to 30 Minute Nap", "Twenty to thirty minute naps are the most reccomended nap lengths. This nap length is the most likely for you to refrain from waking up groggy, while still waking up rejuvenated.", "OK");
        }

        private async void Nap90_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NinetyNap());
        }

        private async void CustomNap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomNap());
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}
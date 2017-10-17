using Plugin.Messaging;
using Plugin.TextToSpeech;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoundV.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaxiPage : ContentPage
	{
		public TaxiPage ()
		{
			InitializeComponent ();
            CrossTextToSpeech.Current.Speak("Would you like to call a taxi?");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();    
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        private void Taxi_Requested()
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
            {
                phoneDialer.MakePhoneCall("91119", "Taxi Request");
            }
            
        }

        private async void Navigate_Down(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CallPage());
        }
    }
}
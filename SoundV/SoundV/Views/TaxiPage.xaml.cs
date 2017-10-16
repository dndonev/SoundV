using Android.Content;
using Plugin.Messaging;
using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossTextToSpeech.Current.Speak("Would you like to call a taxi?");
        }

        private void Taxi_Requested()
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
            {
                phoneDialer.MakePhoneCall("91119", "Taxi Request");
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
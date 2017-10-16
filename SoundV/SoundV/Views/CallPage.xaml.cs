using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.TextToSpeech;
using SoundV.ViewModels;
using Plugin.Messaging;

namespace SoundV.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CallPage : ContentPage
	{
		public CallPage ()
		{
			InitializeComponent();
            BindingContext = new CallViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossTextToSpeech.Current.Speak("Call page");
        }

        private void EmergencyCall_Requested()
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
            {
                phoneDialer.MakePhoneCall("112", "Emergency Call 112");
            }
        }

    }
}
using SoundV.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SoundV
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
            Current.MainPage = new NavigationPage(new Home())
            {
                Title = "Browse",
                Icon = Device.OnPlatform<string>("tab_feed.png", null, null)
            };
        }
	}
}

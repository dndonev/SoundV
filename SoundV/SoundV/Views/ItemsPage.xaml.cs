using System;

using SoundV.Models;
using SoundV.ViewModels;

using Xamarin.Forms;
using Plugin.TextToSpeech;

namespace SoundV.Views
{
	public partial class ItemsPage : ContentPage
	{
		ItemsViewModel viewModel;

		public ItemsPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new ItemsViewModel();
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
			var item = args.SelectedItem as Item;
			if (item == null)
				return;

			await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

			// Manually deselect item
			ItemsListView.SelectedItem = null;
		}

		async void Clock_Clicked(object sender, EventArgs e)
		{
            await Navigation.PushAsync(new ClockTimePage());
            await CrossTextToSpeech.Current.Speak("Clock Page");
            
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (viewModel.Items.Count == 0)
				viewModel.LoadItemsCommand.Execute(null);
		}
	}
}

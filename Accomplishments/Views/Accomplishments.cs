using System;

using Xamarin.Forms;

namespace Accomplishments.Views
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to the Accomplishments App!"
						},
						new StackLayout {
							VerticalOptions = LayoutOptions.CenterAndExpand,
							Orientation = StackOrientation.Horizontal,
							Children = {
								new Entry {
									HorizontalOptions = LayoutOptions.StartAndExpand,
									Placeholder = "Workout      "
								},
								new Entry {
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									Placeholder = "Max Weight"
								},
								new Entry {
									HorizontalOptions = LayoutOptions.EndAndExpand,
									Placeholder = "Max Reps"
								},
							},
						}
					},
				},
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


using BeerOnTap.Views;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BeerOnTap
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "Home",
				IconSource = "contacts.png",
				TargetType = typeof(FeaturePage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Search",
				IconSource = "todo.png",
				TargetType = typeof(BeerSearchPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "About",
				IconSource = "reminders.png",
				TargetType = typeof(ContactsPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}

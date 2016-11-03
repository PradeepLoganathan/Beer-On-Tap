using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BeerOnTap
{
    public partial class BeerSearchPage : ContentPage
    {
        Label resultsLabel;

        public BeerSearchPage()
        {
            Label header = new Label
            {
                Text = "SearchBar",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            SearchBar searchBar = new SearchBar
            {
                Placeholder = "Xamarin.Forms Property",
            };
            searchBar.SearchButtonPressed += OnSearchBarButtonPressed;

            resultsLabel = new Label();
            resultsLabel.Text = "results";

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    searchBar,
                    new ScrollView
                    {
                        Content = resultsLabel,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
        }

        void OnSearchBarButtonPressed(object sender, EventArgs args)
        {
            BreweryDbClient client = new BreweryDbClient("a956af587b434c4c89ef18c7bbd2fac9");

            Models.ResponseContainer<List<Models.Beer>> results = client.Beers.GetAll().Result;

            resultsLabel.Text = results.Data.ToString();
            
            
        }
    }
}


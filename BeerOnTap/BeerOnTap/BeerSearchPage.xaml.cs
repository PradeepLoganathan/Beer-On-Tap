using BeerOnTap.Models;
using Newtonsoft.Json;

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
        List<Beer> Beers;

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

            ListView BeerList = new ListView();

            BeerList.ItemsSource = Beers;





                // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    searchBar,
                    BeerList
                    
                }
            };
        }

        async void OnSearchBarButtonPressed(object sender, EventArgs args)
        {
            //JsonSerializer _serializer = JsonSerializer.CreateDefault();
            //SmartWeb.RestClient rcclient = new SmartWeb.RestClient(new Uri("http://api.brewerydb.com/v2/"), _serializer);
            //rcclient.AddDefaultQueryString("key", "d9b2bcb52bdeb909e004b988b9e55185");
            //SmartWeb.RestRequest rrequest = rcclient.Create("beers");
            //rrequest.AddQueryString("name", "oberon");
            //RestResponse< ResponseContainer < Beer >> rresponse = await rrequest.ExecuteGet<ResponseContainer<Beer>>();
            //var item = await rresponse.GetDataObject().ConfigureAwait(false);
            //resultsLabel.Text = content;


            //BreweryDbClient client = new BreweryDbClient("a956af587b434c4c89ef18c7bbd2fac9");
            //var response = await client.Beers.GetAll();
            //var beer = response.Data.FirstOrDefault(x => x.Labels != null);

            BreweryDbClient client = new BreweryDbClient("a956af587b434c4c89ef18c7bbd2fac9");
            var response = await client.Beers.Search("duvel");
            Beers = response.Data;


        }
    }
}


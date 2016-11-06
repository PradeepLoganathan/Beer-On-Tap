using BeerOnTap.Helpers;
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
        List<Beer> Beers;

        public BeerSearchPage()
        {
            this.Title = "Search for beers";
            InitializeComponent();
            
        }

        protected async override void OnAppearing()
        {

            try
            {
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add(new KeyValuePair<string, string>("hasLabels","Y"));
                BreweryDbClient client = new BreweryDbClient("a956af587b434c4c89ef18c7bbd2fac9");
                //var response = await client.Beers.GetAll(10);
                var response = await client.Beers.Get(parameters);

                Beers = response.Data;
                mylist.ItemsSource = Beers;
                
                
            }
            catch (Exception e)
            {

            }
            
            
            

            


            base.OnAppearing();
        }

        async void SearchCommandExecute()
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

            //create a list view and bind beers to the list view


        }
    }
}


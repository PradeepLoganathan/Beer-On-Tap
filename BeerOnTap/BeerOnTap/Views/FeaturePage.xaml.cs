using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerOnTap.Models;

using Xamarin.Forms;

namespace BeerOnTap.Views
{
    public partial class FeaturePage : ContentPage
    {
        //private BreweryDbClient client;
        //private static Feature feature;
        Feature feature;

        public FeaturePage()
        {
            //feature = null;
            this.Title = "Featured Beer";
            InitializeComponent();
            
        }

        protected async override void OnAppearing()
        {
            BreweryDbClient client = new BreweryDbClient("a956af587b434c4c89ef18c7bbd2fac9");
            var response = await client.Features.Get(DateTime.Today);
            if (response != null && response.Status == "success")
            {
                feature = response.Data;
                BindingContext = feature.Beer;
            }

            
        }

        //async void ButtonClicked(object sender, EventArgs args)
        
        
    }
}

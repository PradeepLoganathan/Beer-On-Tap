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
            InitializeComponent();
            
            
        }

        async void ButtonClicked(object sender, EventArgs args)
        {
            BreweryDbClient client = new BreweryDbClient("a956af587b434c4c89ef18c7bbd2fac9");
            var response = await client.Features.Get(new DateTime(new Random().Next(2010,2015),new Random().Next(1,12), new Random().Next(1,28)));
            if (response != null && response.Status == "success")
            {
                feature = response.Data;
                BindingContext = feature.Beer;
            }
            


        }
        
    }
}

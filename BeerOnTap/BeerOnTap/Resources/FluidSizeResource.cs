﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BeerOnTap.Helpers;
using BeerOnTap.Models;

namespace BeerOnTap.Resources
{
    public class FluidSizeResource<T>
    {
        private readonly BreweryDbClient client;

        public FluidSizeResource(BreweryDbClient breweryDbClient)
        {
            client = breweryDbClient;
        }

        public async Task<ResponseContainer<List<T>>> GetAll()
        {
            var url = $"{BreweryDbClient.BaseAddress}fluidsizes?key={BreweryDbClient.ApplicationKey}&format=json";
            return await JsonDownloader.DownloadSerializedJsonDataAsync<ResponseContainer<List<T>>>(url);
        }

        public async Task<ResponseContainer<T>> Get(string id)
        {
            var url = $"{BreweryDbClient.BaseAddress}fluidsize/{id}?key={BreweryDbClient.ApplicationKey}&format=json";
            return await JsonDownloader.DownloadSerializedJsonDataAsync<ResponseContainer<T>>(url);
        }
    }
}


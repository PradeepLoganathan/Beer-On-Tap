﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BeerOnTap.Helpers;
using BeerOnTap.Models;

namespace BeerOnTap.Resources
{
    public class YeastResource<T>
    {
        private readonly BreweryDbClient client;

        public YeastResource(BreweryDbClient breweryDbClient)
        {
            client = breweryDbClient;
        }

        public async Task<ResponseContainer<List<T>>> GetAll()
        {
            return await GetAll(1);
        }

        public async Task<ResponseContainer<List<T>>> GetAll(int pageNumber)
        {
            var url = $"{BreweryDbClient.BaseAddress}yeasts?p={pageNumber}&key={BreweryDbClient.ApplicationKey}&format=json";
            return await JsonDownloader.DownloadSerializedJsonDataAsync<ResponseContainer<List<T>>>(url);
        }

        public async Task<ResponseContainer<T>> Get(string id)
        {
            var url = $"{BreweryDbClient.BaseAddress}yeast/{id}?key={BreweryDbClient.ApplicationKey}&format=json";
            return await JsonDownloader.DownloadSerializedJsonDataAsync<ResponseContainer<T>>(url);
        }
    }
}


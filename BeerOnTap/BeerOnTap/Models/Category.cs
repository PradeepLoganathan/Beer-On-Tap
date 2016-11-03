
using System;
using BeerOnTap.Interfaces;

namespace BeerOnTap.Models
{
    public class Category : ICategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CreateDate { get; set; }
        public string Description { get; set; }
    }
}
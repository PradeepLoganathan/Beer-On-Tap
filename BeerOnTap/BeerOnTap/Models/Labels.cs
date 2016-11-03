using System;
using BeerOnTap.Interfaces;

namespace BeerOnTap.Models
{
    public class Labels : ILabels
    {
        public string Icon { get; set; }

        public string Medium { get; set; }

        public string Large { get; set; }
    }
}
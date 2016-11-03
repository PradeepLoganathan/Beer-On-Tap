using BeerOnTap.Interfaces;

namespace BeerOnTap.Models
{
    public class Images : IImages
    {
        public string Icon { get; set; }

        public string Medium { get; set; }

        public string Large { get; set; }
    }
}
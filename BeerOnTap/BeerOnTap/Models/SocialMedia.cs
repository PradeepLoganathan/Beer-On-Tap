using System;
using BeerOnTap.Interfaces;

namespace BeerOnTap.Models
{
    public class SocialMedia : ISocialMedia
    {
        public string Id { get; set; }
        public string Website { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
    }
}
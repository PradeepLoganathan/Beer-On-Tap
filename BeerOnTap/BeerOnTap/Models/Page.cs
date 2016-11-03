using System.Collections.Generic;

namespace BeerOnTap.Models
{
    public class Page<T>
    {
        public int CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
        public int TotalResults { get; set; }
        public List<T> Data { get; set; }
    }
}
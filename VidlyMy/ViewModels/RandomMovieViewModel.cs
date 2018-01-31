using System.Collections.Generic;
using VidlyMy.Models;

namespace VidlyMy.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }

    }
}
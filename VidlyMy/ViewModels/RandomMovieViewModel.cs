using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using asp_les_1.Models;

namespace asp_les_1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }

    }
}
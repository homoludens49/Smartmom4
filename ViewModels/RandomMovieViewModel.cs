using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Smartmom4.Models;

namespace Smartmom4.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
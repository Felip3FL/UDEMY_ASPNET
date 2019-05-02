using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UDEMY_ASPNET.Models;

namespace UDEMY_ASPNET.ViewModels
{
    public class RandomMovieViewModel
    {

        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
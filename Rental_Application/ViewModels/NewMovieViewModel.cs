using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental_Application.Models;

namespace Rental_Application.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movies { get; set; }
        //public string Title
        //{
        //    get
        //    {
        //        if (Movies != null && Movies.id != 0)
        //            return "Edit Movie";

        //        return "New Movie";
        //    }
        //}

    }
}
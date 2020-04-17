using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyASP2.Models;

namespace VidlyASP2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }
    }
}
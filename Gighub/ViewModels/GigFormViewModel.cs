using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gighub.Models;

namespace Gighub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public object Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}
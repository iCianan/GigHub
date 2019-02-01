﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gighub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }
        
        public DateTime DateTime { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Required]
        [StringLength(255)]
        public String Venue { get; set; }
    }

}
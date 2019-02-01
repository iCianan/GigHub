﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gighub.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

    }
}
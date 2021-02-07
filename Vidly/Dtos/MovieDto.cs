﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 10)]
        public int NumberInStock { get; set; }

        [Display(Name = "Genre")]
        public byte MovieGenreId { get; set; }
        public MovieGenreDto MovieGenre { get; set; }

    }
}
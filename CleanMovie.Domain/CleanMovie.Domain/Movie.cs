﻿using System;
using System.Collections.Generic;

namespace CleanMovie.Domain
{
    public class Movie
    {
    

        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;

        public decimal RentalCost { get; set; }

        public int RentalDuration { get; set; }


        //Many to Many relation
        public IList<MovieRental> MovieRentals { get; set; }
    }
}

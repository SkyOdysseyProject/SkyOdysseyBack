﻿namespace SkyOdyssey.Models
{
    public class LocationImage
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string ImagePath { get; set; }

        // Navigation property
        public Location Location { get; set; }
    }
}
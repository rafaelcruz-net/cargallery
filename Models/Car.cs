using System;

namespace CarGallery.Models
{
    public class Car
    {
        public Guid CarId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public string CategoryName { get; set; }
    }
    
}
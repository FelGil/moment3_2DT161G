using System;
using System.ComponentModel.DataAnnotations;

namespace moment3_2.Models
{
    public class Cd
    {
         //properties
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Released{ get; set; }

        [Display(Name = "Artist")]
        public int? ArtistId { get; set; }
        //Connect CD to Artist
        public Artist? Artist { get; set; }


        public Cd()
        {
        }
    }
}

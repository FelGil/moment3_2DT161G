using System;
using System.Collections.Generic;

namespace moment3_2.Models
{
    public class Artist
    {
        //properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Cd>? Cds{ get; set; }
    }
}

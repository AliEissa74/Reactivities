using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); // we make the id without rely on database it self
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime Date { get; set; }
        public required string Category { get; set; }
        public bool IsCancelled { get; set; }
        //location prop
        public required string City { get; set; }
        public required string Venue { get; set; }
        public required double Latitude { get; set; } //this 2 prop for the maps integration
        public required double Longitude { get; set; }

    }
}

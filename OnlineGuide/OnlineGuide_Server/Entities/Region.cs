using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGuide_Server.Entities
{
    class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Required]
        public List<City> Cities { get; set; }
        public Country Country { get; set; }

        public Region()
        {
            Cities = new List<City>();
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace OnlineGuide_Server.Entities
{
    class Route
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ListOfLocationsID { get; set; }

        [Required]
        public City City { get; set; }
        [Required]
        public User User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace OnlineGuide_Server.Entities
{
    class City
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Required]
        public Region Region { get; set; }
    }
}

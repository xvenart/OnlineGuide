using System.ComponentModel.DataAnnotations;

namespace OnlineGuide_Server.Entities
{
    class SocialNetwork
    {
        [Key]
        public int ID { get; set; }
        public string LinkVK { get; set; }
        public string LinkInstagram { get; set; }
        public string LinkYT { get; set; }
        public string Mail { get; set; }
    }
}

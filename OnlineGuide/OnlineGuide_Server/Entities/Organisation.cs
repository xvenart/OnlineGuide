using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGuide_Server.Entities
{
    class Organisation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string OGRN { get; set; }
        public string INN { get; set; }
        public string Address { get; set; }

        [Required]
        public User User { get; set; }

        public List<Advertising> Advertisings { get; set; }

        public Organisation()
        {
            Advertisings = new List<Advertising>();
        }
    }
}

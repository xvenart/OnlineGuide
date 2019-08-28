using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineGuide_Server.Entities
{
    class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longtude { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StartOfWorkingDay { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime EndOfWorkingDay { get; set; }

        public TypeOfLocation TypeOfLocation { get; set; }
        [Required]
        public SocialNetwork SocialNetwork { get; set; }
        [Required]
        public City City { get; set; }
    }
}

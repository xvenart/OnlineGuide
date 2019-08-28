using System.Collections.Generic;

namespace OnlineGuide_Server.Entities
{
    class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Region> Regions { get; set; }

        public Country()
        {
            Regions = new List<Region>();
        }
    }
}

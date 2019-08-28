using System;

namespace OnlineGuide_Server.Entities
{
    class Advertising
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public Organisation Organisation { get; set; }
        public TypeOfAdvertising TypeOfAdvertising { get; set; }
    }
}

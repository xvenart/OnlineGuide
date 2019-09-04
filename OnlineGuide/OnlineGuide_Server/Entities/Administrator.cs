namespace OnlineGuide_Server.Entities
{
    class Administrator
    {
        public int ID { get; set; }

        public User User { get; set; }
        public AccessType AccessType { get; set; }
    }
}

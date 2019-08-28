using System;
using System.Data.Entity;
using OnlineGuide_Server.Entities;

namespace OnlineGuide_Server
{
    class OnlineGuideInitializer : CreateDatabaseIfNotExists<OnlineGuideContext>
    {
        protected override void Seed(OnlineGuideContext context)
        { 
            //рандомные заготовочки
            context.TypeOfAdvertisings.Add(
                new TypeOfAdvertising
                {
                    ID = 0,
                    Name = "Base",
                    Description = "Banner"
                });
            context.SaveChanges();

            context.SocialNetworks.Add(
                new SocialNetwork
                {
                    ID = 0,
                    LinkVK = "vk.com",
                    LinkInstagram = "inst.com",
                    LinkYT = "yt.com",
                    Mail = "mail@gmail.com"
                });
            context.SaveChanges();

            context.TypeOfLocations.Add(
                new TypeOfLocation
                {
                    ID = 0,
                    Name = "Education"
                });
            context.SaveChanges();

            context.AccessTypes.Add(
                new AccessType
                {
                    ID = 0,
                    Name = "Base",
                    Description = "CRUD access"
                });

            context.SaveChanges();
        }
    }
}

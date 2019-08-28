using System;

namespace OnlineGuide_Server
{
    class Program
    {
        private static OnlineGuideContext OnlineGuideContext;
        static void Main(string[] args)
        {
            OnlineGuideContext = new OnlineGuideContext();
            OnlineGuideContext.Database.Initialize(false);

            Console.WriteLine("Database initialised.\nPress enter...");

            Console.ReadKey();
        }
    }
}

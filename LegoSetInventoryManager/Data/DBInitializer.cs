using LegoSetInventoryManager.Models;
using LegoSetInventoryManager.Demo.Data;

namespace LegoSetInventoryManager.Demo.Data
{
    public static class DBInitializer
    {
        public static void Initialize(AppDBContext context)
        {
            // Look for any existing Lego Set Records
            if (context.SetNames.Any())
            {
                return;   // DB has been seeded
            }

            var setnames = new SetName[]
            {
                new SetName
                {
                    Title="Razor Crest",

                },
                new SetDetail
                {
                    Theme="Star Wars",
                    SetNumber="75331",
                    Pieces = "6187",
                    MiniFigs = "5",
                    Complete = "Not Purchased",
                },
            };

            context.SetNames.AddRange(setnames);
            context.SaveChanges();
        }
    }
}
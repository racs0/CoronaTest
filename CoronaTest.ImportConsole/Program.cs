using CoronaTest.Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaTest.ImportConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await InitDataAsync();

            Console.WriteLine();
            Console.Write("Beenden mit Eingabetaste ...");
            Console.ReadLine();
        }

        private static async Task InitDataAsync()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("          Import");
            Console.WriteLine("***************************");
            Console.WriteLine("Import der Teststationen in die Datenbank");
            await using var unitOfWork = new UnitOfWork();
            Console.WriteLine("Datenbank löschen");
            await unitOfWork.DeleteDatabaseAsync();
            Console.WriteLine("Datenbank migrieren");
            await unitOfWork.MigrateDatabaseAsync();

            Console.WriteLine("Daten werden von csv-Dateien eingelesen");
            var campaigns = ImportController.ReadFromCsv().ToArray();
            Console.WriteLine($"  {campaigns.Count()} Kampagnen eingelesen");

            await unitOfWork.Campaigns.AddRangeAsync(campaigns);

            Console.WriteLine("Kampagnen werden in Datenbank gespeichert");
            await unitOfWork.SaveChangesAsync();

        }
    }
}

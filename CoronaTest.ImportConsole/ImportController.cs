using CoronaTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace CoronaTest.ImportConsole
{
    public class ImportController
    {
        public static IEnumerable<Campaign> ReadFromCsv()
        {
            string csvCampaign = "Campaigns.csv";
            string csvTestCenters = "TestCenters.csv";

            var matrixCampaigns = MyFile.ReadStringMatrixFromCsv(csvCampaign, true);
            var matrixTestCenters = MyFile.ReadStringMatrixFromCsv(csvTestCenters,true);

            var testCenters = matrixTestCenters
                .Select(line => new TestCenter()
                {
                    Name = line[0],
                    City = line[1],
                    Postalcode = line[2],
                    Street = line[3],
                    SlotCapacity = int.Parse(line[4])
                })
                .ToDictionary(line => line.Name);

            

            var campaigns = matrixCampaigns
                .Select(c => new Campaign
                {
                    Name = c[0],
                    From = Convert.ToDateTime(c[1]),
                    To = Convert.ToDateTime(c[2]),
                    AvailableTestCenters = c[3].Split(',').Select(t => testCenters[t]).ToList()
                })
                .ToArray();



            return campaigns;
        }
    }
}

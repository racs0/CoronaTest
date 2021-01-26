using CoronaTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace CoronaTest.ImportConsole
{
    public class ImportController
    {
        public static IEnumerable<Campaign> ReadFromCsv()
        {
            var csvCampaign = "Products.csv".ReadStringMatrixFromCsv(true);
            var csvTestCenters = "OrderItems.csv".ReadStringMatrixFromCsv(true);

            var testCenters = csvTestCenters
                .Select(line => new TestCenter()
                {
                    Name = line[0],
                    City = line[1],
                    Postalcode = line[2],
                    Street = line[3],
                    SlotCapacity = int.Parse(line[4])
                }).ToDictionary(key => key.Name);

            var campaigns = csvCampaign
                .Select(c => new Campaign
                {
                    Name = c[0],
                    AvailableTestCenters = c[1].Split(',').Select(t => testCenters[t]).ToList(),
                    From = Convert.ToDateTime(c[2]),
                    To = Convert.ToDateTime(c[3])
                })
                .ToList();

            return campaigns;
        }
    }
}

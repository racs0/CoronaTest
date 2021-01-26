using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaTest.Core.Entities
{ 
    public class TestCenter : EntityBase
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Postalcode { get; set; }
        public int SlotCapacity { get; set; }
        public string Street { get; set; }

        public List<Campaign> AvailableInCampaigns { get; set; }

    }
}

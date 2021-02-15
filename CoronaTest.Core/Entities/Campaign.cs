using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaTest.Core.Entities
{
    public class Campaign : EntityBase
    {
        public DateTime From { get; set; }
        public string Name { get; set; }
        public DateTime To { get; set; }

        public List<TestCenter> AvailableTestCenters { get; set; }

    }
}

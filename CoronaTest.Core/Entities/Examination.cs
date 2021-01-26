using CoronaTest.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaTest.Core.Entities
{
    public class Examination : EntityBase
    {
        public TestCenter ExaminationAt { get; set; }
        public string Identifier { get; set; }
        public Campaign Campaign { get; set; }
        public Participant Participant { get; set; }
        public TestCenter TestCenter { get; set; }
        public TestResult Result { get; set; }
        public TestResult State { get; set; }

        public static Examination CreateNew()
        {
            return new Examination();
        }
    }
}

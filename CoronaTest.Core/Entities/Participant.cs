using CoronaTest.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoronaTest.Core.Entities
{
    public class Participant : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Mobilephone { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Door { get; set; }
        public string Stair { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public List<VerificationToken> Verifications { get; set; }


    }
}

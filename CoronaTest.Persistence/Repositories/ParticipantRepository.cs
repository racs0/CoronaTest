using CoronaTest.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaTest.Persistence.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        private ApplicationDbContext _dbContext;

        public ParticipantRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}

using CoronaTest.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaTest.Persistence.Repositories
{
    public class ExaminationRepository : IExaminationRepository
    {
        private ApplicationDbContext _dbContext;

        public ExaminationRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}

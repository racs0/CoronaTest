using CoronaTest.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaTest.Persistence.Repositories
{
    public class TestCenterRepository : ITestCenterRepository
    {
        private ApplicationDbContext _dbContext;

        public TestCenterRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}

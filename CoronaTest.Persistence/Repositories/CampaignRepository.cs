using CoronaTest.Core.Contracts;
using CoronaTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTest.Persistence.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private ApplicationDbContext _dbContext;

        public CampaignRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task AddRangeAsync(IEnumerable<Campaign> campaigns)
        {
            await _dbContext.Campaigns.AddRangeAsync(campaigns);
        }
    }
}

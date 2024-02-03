using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NW.KnowledgeSpace.Backend.Data;

namespace NW.KnowledgeSpace.Backend.UnitTest
{
    public class InMemoryDbContextFactory
    {
        public ApplicationDbContext GetApplicationDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryApplicationDatabase")
                .Options;
            var dbContext = new ApplicationDbContext(options);

            return dbContext;
        }
    }
}

using GrandTheftInfo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Tests
{
    public class DatabaseMock
    {
        public static GrandTheftInfoDbContext Instance
        {
            get
            {
                var contextOptions = new DbContextOptionsBuilder<GrandTheftInfoDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

                return new GrandTheftInfoDbContext(contextOptions);
            }
        }
    }
}

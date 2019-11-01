using Microsoft.EntityFrameworkCore;

namespace InTouch.Database
{
    public class InTouchDbContext: Data.InTouchDbContext
    {
        public InTouchDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testAPBD.Services
{
    public interface IDatabaseService
    {
        //gonna write tasks here
    }
    public class DatabaseService : IDatabaseService
    {
        private readonly IDbContext _context;

        public DatabaseService(IDbContext context)
        {
            _context = context;
        }
        //tasks more
    }
}

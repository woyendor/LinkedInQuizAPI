using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedInQuizAPI
{
    public class LIQuizContext : DbContext
    {

        public LIQuizContext(DbContextOptions<LIQuizContext> options) : base(options) { }

        public DbSet<Models.Question>  Questions{ get; set; }
    }
}

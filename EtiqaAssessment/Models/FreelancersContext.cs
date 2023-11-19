using Microsoft.EntityFrameworkCore;

namespace EtiqaAssessment.Models
{
    public class FreelancersContext: DbContext
    {
        public FreelancersContext(DbContextOptions<FreelancersContext> options) : base(options)
        {

        }
        public DbSet<Freelancers> Freelancers { get; set; }
    }
}

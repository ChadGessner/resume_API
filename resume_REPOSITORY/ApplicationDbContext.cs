using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using resume_MODELS.DTO;

namespace resume_REPOSITORY
{
    public class ApplicationDbContext : DbContext
    {
        private static IConfigurationRoot _configuration;


        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration= builder.Build();
                string cnstr = _configuration.GetConnectionString("StringyConnections");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }
        public DbSet<Root_DTO> roots { get; set; }
        public DbSet<Awards_DTO> awards { get; set; }
        public DbSet<Basics_DTO> basics { get; set; }
        public DbSet<Education_DTO> educations { get; set; }
        public DbSet<Headings_DTO> headings { get; set; }
        public DbSet<Location_DTO> location { get; set; }
        public DbSet<Projects_DTO> projects { get; set; }
        public DbSet<Skills_DTO> skills { get; set; }
        public DbSet<Work_DTO> work { get; set; }
        public DbSet<Keyword_DTO> keywords { get; set; }
        public DbSet<Highlight_DTO> highlights { get; set; }
        public DbSet<Section_DTO> sections { get; set; }
    }
}
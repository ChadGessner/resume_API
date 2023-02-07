using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using resume_MODELS.API;
using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_REPOSITORY
{
    public class Repository
    {
        private IConfigurationRoot _configuration;
        private DbContextOptionsBuilder<ApplicationDbContext> _optionsBuilder;
        public Repository()
        {
            BuildOptions();
        }
        private void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("StringyConnections"));
        }
        public bool AddResumeToDb(Root_DTO root)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Add(root);
                db.SaveChanges();
            }
            return true;
        }
        public Root GetResumeFromDb()
        {
            Root_DTO dto;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                dto = db.roots
                    .Include(r => r.headings)
                    .Include(r => r.basics)
                    .ThenInclude(b => b.location)
                    .Include(r => r.education)
                    .Include(r => r.work )
                    .ThenInclude(w => w.highlights)
                    .Include(r => r.skills)
                    .ThenInclude(s => s.keywords)
                    .Include(r => r.projects)
                    .ThenInclude(p => p.keywords)
                    .Include(r => r.awards)
                    .Include(r => r.sections)
                    .FirstOrDefault(r => r.Id == 1); 
                if (dto == null)
                {

                    throw new Exception();
                }
                return Root.GetAPIFromDTO(dto);
            }
        }
    }
}

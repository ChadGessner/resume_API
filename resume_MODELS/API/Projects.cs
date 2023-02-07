using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resume_MODELS.API;
namespace resume_MODELS.API
{
    public class Projects
    {
        public string name { get; set; }
        public List<string> keywords { get; set; }
        public string description { get; set; }
        public static List<Keyword_DTO> GetKeywords(List<string> key)
        {
            return key
                .Select(k => new Keyword_DTO() { keyword = k })
                .ToList();
        }

        public static Projects_DTO GetDTOFromAPI(Projects projects)
        {
            return new Projects_DTO()
            {
                name = projects.name,
                keywords = Projects.GetKeywords(projects.keywords),
                description = projects.description,
            };
        }
        public static Projects GetAPIFromDTO(Projects_DTO projects)
        {
            return new Projects()
            {
                name = projects.name,
                keywords = Projects.GetStringList(projects.keywords),
                description = projects.description,
            };
        }
        public static List<string> GetStringList(List<Keyword_DTO> keywords)
        {
            return keywords.Select(k=> k.keyword).ToList();
        }

    }
}

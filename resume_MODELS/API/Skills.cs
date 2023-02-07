using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resume_MODELS.DTO;
namespace resume_MODELS.API
{
    public class Skills
    {
        public string? level { get; set; }
        public List<string?> keywords { get; set; }
        public string name { get; set; }
        public static List<string> GetStringList(List<Keyword_DTO> keywords)
        {
            return keywords.Select(k=> k.keyword).ToList();
        }
        public static List<Keyword_DTO> GetKeywordsDTO(List<string> keywords)
        {
            return keywords.Select(k=> new Keyword_DTO() { keyword = k} ).ToList();
        }
        public static Skills_DTO GetDTOFromAPI(Skills skills)
        {
            return new Skills_DTO()
            {
                level = skills.level,
                keywords = Skills.GetKeywordsDTO(skills.keywords),
                name = skills.name
            };
        }
        public static Skills GetAPIFromDTO(Skills_DTO skills)
        {
            return new Skills()
            {
                level = skills.level,
                keywords = Skills.GetStringList(skills.keywords),
                name = skills.name
            };
        }
    }
}

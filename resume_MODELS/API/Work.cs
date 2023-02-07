using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.API
{
    public class Work
    {
        public string company { get; set; }
        public string location { get; set; }
        public string position { get; set; }
        public string? website { get; set; }
        public string endDate { get; set; }
        public List<string> highlights { get; set; }
        public string startDate { get; set; }
        public static List<Highlight_DTO> GetHighlights(List<string> highlights)
        {
            return highlights.Select(h => new Highlight_DTO() { highlight= h }).ToList();
        }
        public  static Work_DTO GetDTOFromAPI(Work work)
        {
            return new Work_DTO() 
            {
                company = work.company,
                location = work.location,
                position = work.position,
                website = work.website,
                endDate = work.endDate,
                highlights = Work.GetHighlights(work.highlights),
                startDate = work.startDate,
            };
        }
        public static List<string> GetStringList(List<Highlight_DTO> highlights)
        {
            return highlights.Select(h=> h.highlight).ToList();
        }
        public static Work GetAPIFromDTO(Work_DTO work)
        {
            return new Work()
            {
                company = work.company,
                location = work.location,
                position = work.position,
                website = work.website,
                endDate = work.endDate,
                highlights = Work.GetStringList(work.highlights),
                startDate = work.startDate,
            };
        }
    }
}

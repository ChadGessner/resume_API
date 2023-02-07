using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.API
{
    public class Headings
    {
        public string work { get; set; }
        public string education { get; set; }
        public string awards { get; set; }
        public string skills { get; set; }
        public string projects { get; set; }
        public static Headings_DTO GetDTOFromAPI(Headings headings)
        {
            return new Headings_DTO() 
            {
                work = headings.work,
                education= headings.education,
                awards= headings.awards,
                skills= headings.skills,
                projects= headings.projects,
            };
        }
        public static Headings GetAPIFromDTO(Headings_DTO headings)
        {
            return new Headings()
            {
                work = headings.work,
                education = headings.education,
                awards = headings.awards,
                skills = headings.skills,
                projects = headings.projects,
            };
        }
    }
}

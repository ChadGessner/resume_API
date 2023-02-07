using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.API
{
    public class Education
    {
        public string institution { get; set; }
        public string location { get; set; }
        public string endDate { get; set; }
        public string startDate { get; set; }
        public string studyType { get; set; }
        public static Education_DTO GetDTOFromAPI(Education education)
        {
            return new Education_DTO() 
            { 
                endDate = education.endDate, 
                startDate = education.startDate,
                studyType= education.studyType,
                location= education.location,
                institution= education.institution,
            };
        }
        public static Education GetAPIFromDTO(Education_DTO education)
        {
            return new Education()
            {
                endDate = education.endDate,
                startDate = education.startDate,
                studyType = education.studyType,
                location = education.location,
                institution = education.institution,
            };
        }
    }
}

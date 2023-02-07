using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.API
{
    public class Awards
    {
        public string title { get; set; }
        public string awarder { get; set; }
        public string date { get; set; }
        public static Awards_DTO GetDTOFromAPI(Awards awards)
        {
            return new Awards_DTO() 
            { 
                title= awards.title,
                awarder= awards.awarder,
                date= awards.date,
            } ;
        }
        public static Awards GetAPIFromDTO(Awards_DTO awards)
        {
            return new Awards()
            {
                title = awards.title,
                awarder = awards.awarder,
                date = awards.date,
            };
        }
    }
}

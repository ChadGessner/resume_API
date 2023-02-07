using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resume_MODELS.API;
namespace resume_MODELS.API
{
    public class Basics
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public Location location { get; set; }
        public string website { get; set; }
        public static Basics_DTO GetDTOFromAPI(Basics basics)
        {
            return new Basics_DTO() 
            {
                name = basics.name,
                email = basics.email,
                phone = basics.phone,
                location = Location.GetDTOFromAPI(basics.location),
                website = basics.website,
            };
        }
        public static Basics GetAPIFromDTO(Basics_DTO basics)
        {
            return new Basics()
            {
                name = basics.name,
                email = basics.email,
                phone = basics.phone,
                location = Location.GetAPIFromDTO(basics.location),
                website = basics.website,
            };
        }
    }
}

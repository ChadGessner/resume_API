using resume_MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.API
{
    public class Location
    {
        public string address { get; set; }
        public static Location_DTO GetDTOFromAPI(Location location)
        {
            return new Location_DTO() 
            {
                address = location.address,
            };
        }
        public static Location GetAPIFromDTO(Location_DTO location)
        {
            return new Location()
            {
                address = location.address,
            };
        }
    }
}

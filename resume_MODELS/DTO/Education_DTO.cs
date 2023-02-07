using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.DTO
{
    public class Education_DTO
    {
        [Key]
        public int Id { get; set; }
        public string institution { get; set; }
        public string location { get; set; }
        public string endDate { get; set; }
        public string startDate { get; set; }
        public string studyType { get; set; }

    }
}

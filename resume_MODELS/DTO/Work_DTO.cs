using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.DTO
{
    public class Work_DTO
    {
        [Key]
        public int Id { get; set; }
        public string company { get; set; }
        public string location { get; set; }
        public string position { get; set; }
        public string? website { get; set; }
        public string endDate { get; set; }
        public virtual List<Highlight_DTO> highlights { get; set; }
        public string startDate { get; set; }
    }
}

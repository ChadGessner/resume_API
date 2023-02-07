using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.DTO
{
    public class Projects_DTO
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public virtual List<Keyword_DTO> keywords { get; set; }
        public string description { get; set; }
    }
}

using resume_MODELS.API;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.DTO
{
    public class Root_DTO
    {
        [Key]
        public int Id { get; set; }
        public int selectedTemplate { get; set; }
        public virtual Headings_DTO headings { get; set; }
        public virtual Basics_DTO basics { get; set; }
        public virtual List<Education_DTO> education { get; set; }
        public virtual List<Work_DTO> work { get; set; }
        public virtual List<Skills_DTO> skills { get; set; }
        public virtual List<Projects_DTO> projects { get; set; }
        public virtual List<Awards_DTO> awards { get; set; }
        public virtual List<Section_DTO> sections { get; set; }
    }
}

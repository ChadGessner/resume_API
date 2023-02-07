using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.DTO
{
    public class Highlight_DTO
    {
        [Key]
        public int Id { get; set; }
        public string highlight { get; set; }
    }
}

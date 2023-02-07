using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.DTO
{
    public class Awards_DTO
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string awarder { get; set; }
        public string date { get; set; }
    }
}

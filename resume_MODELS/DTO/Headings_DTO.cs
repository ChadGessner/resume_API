using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume_MODELS.DTO
{
    public class Headings_DTO
    {
        [Key] 
        public int Id { get; set; }
        public string work { get; set; }
        public string education { get; set; }
        public string awards { get; set; }
        public string skills { get; set; }
        public string projects { get; set; }
    }
}

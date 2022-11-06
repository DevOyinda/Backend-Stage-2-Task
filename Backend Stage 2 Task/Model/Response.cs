using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Stage_2_Task.Model
{
    public class Response
    {
        public string slackUsername { get; set; }

        public int result { get; set; }

        public string operation_type { get; set; }
    }

    public class Input
    {
        [Required]
        public string operation_type { get; set; }

        [Required]
        public int x { get; set; }

        [Required]
        public int y { get; set; }       
    }


    public enum Oyin
    {
        addition,
        subtraction,
        multiplication
    }
}

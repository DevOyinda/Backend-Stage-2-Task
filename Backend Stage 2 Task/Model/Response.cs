using System;
using System.Collections.Generic;
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
        public int x { get; set; }

        public int y { get; set; }

        public Oyin operation_type { get; set; }
    }


    public enum Oyin
    {
        Addition = 1,
        Substraction,
        Multiplication
    }
}

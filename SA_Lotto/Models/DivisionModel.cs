using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Lotto.Models
{
    public enum Division
    {
        Division1 = 1,
        Division2,
        Division3,
        Division4,
        Division5,
        Division6,
        Division7,
        Division8
    }
    public class DivisionModel
    {
        public string Result { get; set; }
        public Division ? Division { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPlanServiceApp
{
    public class Shift
    {
        public int id { get; set; }
        public int preference { get; set; }
        public string dayDate { get; set; }
        public string hourStart { get; set; }
        public string hourStop { get; set; }
    }
}

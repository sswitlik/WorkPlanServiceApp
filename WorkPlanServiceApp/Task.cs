﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPlanServiceApp
{
    public class Task
    {
        public int id { get; set; }
        public string shortName { get; set; }
        public int shiftSum { get; set; }
        public List<Shift> shiftList;

    }
}

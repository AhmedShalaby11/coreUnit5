using System;
using System.Collections.Generic;

namespace unit5.Models
{
    public partial class ConfIntervention
    {
        public int Recid { get; set; }
        public string InterventionName { get; set; }
        public string Type { get; set; }
        public DateTime? RecDate { get; set; }
    }
}

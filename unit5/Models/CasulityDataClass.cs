using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace unit5.Models
{
    public class CasulityDataClass
    {

        public int Recid { get; set; }
        public string ParityValue { get; set; }
        public string AddedValue { get; set; }
        public int Weeks { get; set; }
        public int Days { get; set; }
        public string Presentation { get; set; }
        public string State { get; set; }
        public string Intervention { get; set; }
        public string Outcome { get; set; }
        public string Sex { get; set; }
        public string ChildState { get; set; }
        public double Weight { get; set; }
        public string Complications { get; set; }
        public string Dynamics { get; set; }
        public string Surgeons { get; set; }
        public string Assistants { get; set; }
        public string Supervisors { get; set; }
        public DateTime? RecDate { get; set; }

    }
}

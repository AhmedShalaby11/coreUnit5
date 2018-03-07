using System;
using System.Collections.Generic;

namespace unit5.Models
{
    public partial class PatientDiagnose
    {
        public int Recid { get; set; }
        public string Ga { get; set; }
        public string ChildPresentation { get; set; }
        public string ChildState { get; set; }
        public DateTime? PositiveDate { get; set; }
        public string Intervention { get; set; }
        public string Outcome { get; set; }
        public string OutcomeSex { get; set; }
        public double? OutcomeWeight { get; set; }
        public string OutcomeState { get; set; }
        public string CsIndication { get; set; }
        public string Surgeon { get; set; }
        public string Assistant { get; set; }
        public string Supervisor { get; set; }
        public string Complications { get; set; }
        public string Dynamics { get; set; }
        public DateTime? RecDate { get; set; }
    }
}

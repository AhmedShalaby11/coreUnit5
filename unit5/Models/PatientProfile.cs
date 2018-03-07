using System;
using System.Collections.Generic;

namespace unit5.Models
{
    public partial class PatientProfile
    {
        public int Recid { get; set; }
        public string PatientName { get; set; }
        public string PatientId { get; set; }
        public DateTime? PatientBirthdate { get; set; }
        public double? PatientAge { get; set; }
        public string PatientSex { get; set; }
        public string PatientContact { get; set; }
        public string PatientAddress { get; set; }
        public string PatientEmail { get; set; }
        public string PatientImageUrl { get; set; }
        public DateTime? RecDate { get; set; }
    }
}

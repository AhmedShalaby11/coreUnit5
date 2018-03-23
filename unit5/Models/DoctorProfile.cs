using System;
using System.Collections.Generic;

namespace unit5.Models
{
    public partial class DoctorProfile
    {
        public int Recid { get; set; }
        public string DoctorName { get; set; }
        public string DoctorTitle { get; set; }
        public string DoctorDegree { get; set; }
        public string DoctorMail { get; set; }
        public string DoctorMobile { get; set; }
        public string DoctorLocation { get; set; }
        public DateTime? DoctorBachYear { get; set; }
        public DateTime? DoctorMcsYear { get; set; }
        public DateTime? DoctorPhdYear { get; set; }
        public DateTime? DoctorBirthdate { get; set; }
        public string DoctorOtherDegrees { get; set; }
        public string DoctorOtherQualifications { get; set; }
        public string DoctorImageUrl { get; set; }
        public string DoctorPrecense { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}

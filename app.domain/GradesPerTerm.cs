using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace app.domain
{
    public class GradesPerTerm : BaseEntity
    {
        public float PrelimGrade { get; set; }
        public float MidtermGrade { get; set; }
        public float PrefinalGrade { get; set; }
        public float FinalGrade { get; set; }
        public float Grade { get; set; }
    }
}

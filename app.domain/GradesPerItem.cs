using System;
using System.Collections.Generic;
using System.Text;

namespace app.domain
{
    public class GradesPerItem : BaseEntity
    {
        public int CreatedBy { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int TermID { get; set; }
        public GradesPerTerm Term { get; set; }

    }
}

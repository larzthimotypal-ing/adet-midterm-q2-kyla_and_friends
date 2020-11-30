using System;
using System.Collections.Generic;
using System.Text;

namespace app.domain
{
    public class StudentAdminRelationship : BaseEntity
    {
        public int? StudentID { get; set; }
        public int? ProfessorID { get; set; }
        public Student Student { get; set; }
        public Professor Admin { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace app.domain
{
    class StudentAdminRelationship : BaseEntity
    {
        public int? StudentID { get; set; }
        public int? AdminID { get; set; }
        public Student Student { get; set; }
        public Admin Admin { get; set; }
    }
}

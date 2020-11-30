using System;
using System.Collections.Generic;
using System.Text;

namespace app.domain
{
    public class Subject : BaseEntity
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Units { get; set; }
    }
}

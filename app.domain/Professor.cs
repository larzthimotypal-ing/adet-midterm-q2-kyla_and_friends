using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace app.domain
{
    public class Professor : BaseEntity
    {
        public Professor()
        {
            Subjects = new HashSet<Subject>();
            Students = new HashSet<Student>();
        }
        [Column("varchar(255)")]
        public string Department { get; set; }
        public Person Person { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace app.domain
{
    public class Student : BaseEntity
    {
        [Column("varchar(255)")]
        public string StudentNumber { get; set; }
        [Column("varchar(255)")]
        public string Course { get; set; }
        [Column("varchar(255)")]
        public string YearLevel { get; set; }
        [Column("varchar(255)")]
        public string Section { get; set; }
    }
}

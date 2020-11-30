using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace app.domain
{
    public class Person : BaseEntity
    {
        [Column("varchar(255)")]
        public string FirstName { get; set; }
        [Column("varchar(255)")]
        public string LastName { get; set; }
        [Column("varchar(255)")]
        public string MiddleInitial { get; set; }
        [Column("varchar(255)")]
        public string Gender { get; set; }
        [Column("varchar(13)")]
        public string ContactNumber { get; set; }


    }
}

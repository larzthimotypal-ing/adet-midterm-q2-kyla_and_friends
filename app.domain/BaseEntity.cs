using System;
using System.ComponentModel.DataAnnotations;

namespace app.domain
{
    public class BaseEntity
    {
        [Key]
        int ID { get; set; }
    }
}

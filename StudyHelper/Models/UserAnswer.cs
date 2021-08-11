using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyHelper.Models
{
    [Table("UserAnswer")]
    public class UserAnswer : Answer
    {
        public string UserId { get; set; }
    }
}

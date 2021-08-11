using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyHelper.Models
{
    public class Question
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public CorrectAnswer CorrectAnswer { get; set; }
        [NotMapped]
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}

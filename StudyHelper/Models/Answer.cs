using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyHelper.Models
{
    [Table("Answer")]
    public class Answer
    {
        [Key, Required]
        public int Id { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        [Required]
        public AnswerOption AnswerOption { get; set; }
    }
}

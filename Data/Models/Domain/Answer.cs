using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Domain
{
    [Table("answers")]
    public class Answer
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("value")]
        public string Value { get; set; } = string.Empty;
        [Column("question_id")]
        public Guid QuestionId { get; set; }
        public Question? Question { get; set; }
        [Column("next_question_id")]
        public Guid? NextQuestionId { get; set; }
        public Question? NextQuestion { get; set; }
        [Column("created_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updated_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }

}
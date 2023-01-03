using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Domain
{
    [Table("questions")]
    public class Question
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("body")]
        public string Body { get; set; } = string.Empty;
        [Column("question_type")]
        public string QuestionType { get; set; } = string.Empty;
        [Column("choices", TypeName = "jsonb")]
        public List<Choices>? Choices { get; set; }
        [Column("created_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updated_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    }
    public class Choices
    {
        public string value { get; set; } = string.Empty;
    }
}

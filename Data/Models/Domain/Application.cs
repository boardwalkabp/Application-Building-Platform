using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Domain
{
    [Table("applications")]
    public class Application
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("status")]
        public string Status { get; set; } = "Not Started";
        [Column("created_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updated_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        [Column("completed_at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CompletedAt { get; set; }
        [Column("questions", TypeName = "jsonb")]
        public List<Question_branching>? Questions { get; set; }
        [Column("answers", TypeName = "jsonb")]
        public List<AnswerValue>? Answers { get; set; }
        [Column("client_id")]
        public Guid ClientId { get; set; }
        [Column("category_id")]
        public Guid CategoryId { get; set; }

    }
    public class Question_branching
    {
        public string value { get; set; } = string.Empty;
    }

    public class AnswerValue
    {
        public Guid QuestionId { get; set; }

        public string value { get; set; } = string.Empty;
    }
}

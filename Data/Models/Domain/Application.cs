using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Domain
{
    [Table("applications")]
    public class Application
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CompletedAt { get; set; }
        [Column(TypeName = "jsonb")]
        public List<Question_branching>? Questions { get; set; }
        [Column(TypeName = "jsonb")]
        public List<AnswerValue>? Answers { get; set; }
        public Guid ClientId { get; set; }
        public Guid CategoryId { get; set; }

    }
    public class Question_branching
    {
        // public Guid Id { get; set; }
        public string value { get; set; } = string.Empty;
    }

    public class AnswerValue
    {
        //public Guid Id { get; set; }
        public string value { get; set; } = string.Empty;
    }
}

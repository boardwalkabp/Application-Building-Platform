using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Domain
{
    [Table("questions")]
    public class Question
    {
        public Guid Id { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Options { get; set; } = string.Empty;
        public string QuestionType { get; set; } = string.Empty;
        public virtual Category? Category { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "jsonb")]
        public List<Choices>? Choices { get; set; }
        // public string[] Choices { get; set; } = Array.Empty<string>();

    }
    public class Choices
    {
        public string value { get; set; } = string.Empty;
    }
}

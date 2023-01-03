using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace API.Models.Domain
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("name")]
        [Required, MinLength(2), MaxLength(100), Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;
        [Column("username")]
        [Required, MaxLength(50)]
        public string Username { get; set; } = string.Empty;
        [Column("email")]
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Column("password_hash")]
        public byte[] PasswordHash { get; set; } = new byte[32];
        [Column("password_salt")]
        public byte[] PasswordSalt { get; set; } = new byte[32];
        [Column("verification_token")]
        public string? VerificationToken { get; set; }
        [Column("verified_at")]
        public DateTime? VerifiedAt { get; set; }
        [Column("reset_token")]
        public string? PasswordResetToken { get; set; }
        [Column("reset_token_expires")]
        public DateTime? ResetTokenExpires { get; set; }
        [Column("address")]
        [Required, MaxLength(100), PersonalData]
        public string Address { get; set; } = string.Empty;
        [Column("phone_number")]
        [Required, Phone, PersonalData]
        public string PhoneNumber { get; set; } = string.Empty;
        [Column("role")]
        public string Role { get; set; } = "Client";
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

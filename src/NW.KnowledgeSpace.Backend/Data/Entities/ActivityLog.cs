using NW.KnowledgeSpace.Backend.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NW.KnowledgeSpace.Backend.Data.Entities
{
    [Table("ActivityLogs")]
    public class ActivityLog : IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Action { get; set; } = string.Empty;

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string EntityName { get; set; } = string.Empty;

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string EntityId { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string? UserId { get; set; }

        [MaxLength(500)]
        public string? Content { get; set; }
    }
}

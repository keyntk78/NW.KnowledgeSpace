using NW.KnowledgeSpace.Backend.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NW.KnowledgeSpace.Backend.Data.Entities
{
    [Table("Votes")]
    public class Vote : IDateTracking
    {
        public int KnowledgeBaseId { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string UserId { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}

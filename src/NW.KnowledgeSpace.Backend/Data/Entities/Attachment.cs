﻿using NW.KnowledgeSpace.Backend.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NW.KnowledgeSpace.Backend.Data.Entities
{
    [Table("Attachments")]
    public class Attachment : IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string FileName { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string FilePath { get; set; } = string.Empty;

        [Required]
        [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string FileType { get; set; } = string.Empty;

        [Required]
        public long FileSize { get; set; }

        public int? KnowledgeBaseId { get; set; }

        public int? CommentId { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string Type { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}

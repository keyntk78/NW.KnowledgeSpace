﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NW.KnowledgeSpace.Backend.Data.Entities
{
    [Table("CommandInFunctions")]
    public class CommandInFunction
    {
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string CommandId { get; set; } = string.Empty;

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string FunctionId { get; set; } = string.Empty;
    }
}

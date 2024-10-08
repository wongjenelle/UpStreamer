﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UpStreamer.Server.Database.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public required string Name { get; set; }
    }
}

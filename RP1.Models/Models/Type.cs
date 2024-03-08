﻿using System.ComponentModel.DataAnnotations;

namespace RP1.Models.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? TypeName { get; set; }
        [Required]
        public int Cost { get; set; }
        

        public List<Ticket> Tickets { get; set; }
    }
}

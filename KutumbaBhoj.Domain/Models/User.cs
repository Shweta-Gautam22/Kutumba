﻿using System.ComponentModel.DataAnnotations;

namespace KutumbaBhoj.Domain.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; }
        public long ContactInformation { get; set; }
        
    }
}

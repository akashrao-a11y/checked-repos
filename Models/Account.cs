﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankManagementSystem.Models
{
    [Table("Accounts", Schema = "training")]
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public string AccountNumber { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BankId { get; set; }

        public decimal Balance { get; set; } = 0;

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("BankId")]
        public Bank Bank { get; set; }
    }
}

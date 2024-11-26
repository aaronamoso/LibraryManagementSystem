using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class UserAccount
    {
        [Key] // Specifies the primary key
        public int Id { get; set; }

        [Required] // Name is required
        [MaxLength(100)] // Limits the Name column to 100 characters
        public string Name { get; set; }

        [Required] // Email is required
        [EmailAddress] // Validates email format
        public string Email { get; set; }
    }
}

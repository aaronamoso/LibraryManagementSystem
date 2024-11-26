using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class LibraryItem
    {
        [Key] // Specifies the primary key
        public int Id { get; set; }

        [Required] // Makes the Title column NOT NULL
        [MaxLength(200)] // Limits the Title column to 200 characters
        public string Title { get; set; }

        public bool IsOverdue { get; set; } // Boolean for overdue status
    }
}

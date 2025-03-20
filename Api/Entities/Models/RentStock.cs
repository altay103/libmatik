using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RentStock
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public int BookId { get; set; } 
        public DateTime Time { get; set; } = DateTime.UtcNow; 

        public RentStatus Status { get; set; } = RentStatus.Rented; 

        // Navigation Properties
        public User User { get; set; }
        public Book Book { get; set; }
    }

    public enum RentStatus
    {
        Rented, 
        Returned 
    }
}

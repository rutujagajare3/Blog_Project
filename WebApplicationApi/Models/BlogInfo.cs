using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationApi.Models
{
    [Table("BlogInfo")]
    public class BlogInfo
    {
        [Key]
        [Required]
        public int BlogId { get; set; }
        public string Title { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public DateTime DateOfCreation { get; set; }
        public string BlogUrl { get; set; } = null!;
        public string? EmpEmailId { get; set; }

        public virtual EmpInfo? EmpEmail { get; set; }
    }
}

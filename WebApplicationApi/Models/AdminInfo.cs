using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationApi.Models
{
    [Table("AdminInfo")]
    public class AdminInfo
    {
        [Key]
        
        public string EmailId { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationApi.Models
{
    [Table("EmpInfo")]

    public class EmpInfo
    {
        
        
        public EmpInfo()
        {
            BlogInfos = new HashSet<BlogInfo>();
        }
        [Key]

        public string EmailId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime DateOfJoining { get; set; }
        public int? PassCode { get; set; }

        public virtual ICollection<BlogInfo> BlogInfos { get; set; }
    }
}

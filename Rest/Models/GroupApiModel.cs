using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Models
{
    [Table("Groups")]
    public class GroupApiModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}

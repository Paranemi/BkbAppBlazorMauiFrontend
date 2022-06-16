using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Models
{
    [Table("Events")]
    public class EventApiModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey(nameof(Group))]
        public Guid? GroupId { get; set; }

        public virtual GroupApiModel Group { get; set; }
    }
}

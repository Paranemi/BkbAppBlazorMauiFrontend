using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Models
{
    [Table("Participations")]
    public class ParticipationApiModel
    {
        [Key]
        public Guid Id { get; set; }

        public bool Participate { get; set; }

        public string Reason { get; set; }

        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        public UserApiModel User { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid? EventId { get; set; }

        public EventApiModel Event { get; set; }
    }
}

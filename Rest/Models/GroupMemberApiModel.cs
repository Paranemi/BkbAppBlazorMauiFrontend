using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Models
{
    [Table("GroupMembers")]
    public class GroupMemberApiModel
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        public UserApiModel User { get; set; }

        [ForeignKey(nameof(Group))]
        public Guid? GroupId { get; set; }

        public GroupApiModel Group { get; set; }
    }
}

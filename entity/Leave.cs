using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muja.entity
{
    public class Leave : Base
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int LeavetypeId { get; set; }
        [ForeignKey(nameof(LeavetypeId))]
        public LeaveType LeaveType { get; set; }
    }
}

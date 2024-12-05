using System.ComponentModel.DataAnnotations;

namespace muja.entity
{
    public class LeaveType : Base
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}

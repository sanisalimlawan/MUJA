using System.ComponentModel.DataAnnotations;

namespace muja.entity
{
    public class Department : Base
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

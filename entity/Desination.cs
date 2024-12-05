using System.ComponentModel.DataAnnotations;

namespace muja.entity
{
    public class Desination : Base
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

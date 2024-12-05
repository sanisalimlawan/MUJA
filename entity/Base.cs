using System.ComponentModel.DataAnnotations;

namespace muja.entity
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Modified { get; set; }
        public string? LastMOdefied { get; set; }

        protected Base() 
        {
            Created = DateTime.UtcNow;
            IsDeleted = false;
        }
    }
}

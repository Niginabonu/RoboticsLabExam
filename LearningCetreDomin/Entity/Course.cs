using LearningCetreDomin.Commons;

namespace LearningCetreDomin.Entity
{
    public class Course : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long TeacherId { get; set; }
        public decimal Price { get; set; }
    }
}

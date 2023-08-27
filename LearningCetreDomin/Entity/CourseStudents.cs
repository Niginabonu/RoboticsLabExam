using LearningCetreDomin.Commons;

namespace LearningCetreDomin.Entity
{
    public class CourseStudents : Auditable
    {
        public long CourseId { get; set; }
        public long StudentId { get; set; }
    }
}

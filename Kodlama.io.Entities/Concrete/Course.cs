using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities.Concrete
{
    public class Course
    {
        public int CourseID { get; set; }
        public int CategoryID { get; set; }
        public int InstructorID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompletionRate { get; set; }

        public override string ToString()
        {
            return $"Course ID: {CourseID} - Course Name: {Name} - Description: {Description} - Completion Rate: %{CompletionRate}";
        }
    }
}

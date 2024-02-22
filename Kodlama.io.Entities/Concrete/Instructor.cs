using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities.Concrete
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Instructor ID: {InstructorID} - First Name: {FirstName} - Last Name: {LastName}";
        }
    }
}

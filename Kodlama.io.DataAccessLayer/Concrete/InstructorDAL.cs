using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccessLayer.Concrete
{
    public class InstructorDAL : IInstructorDAL
    {
        List<Instructor> instructors;
        public InstructorDAL()
        {
            Instructor instructor1 = new Instructor
            {
                InstructorID = 1,
                FirstName = "Engin",
                LastName = "Demiroğ"
            };

            Instructor instructor2 = new Instructor
            {
                InstructorID = 2,
                FirstName = "Halit Enes",
                LastName = "Kalaycı"
            };

            instructors = new List<Instructor> { instructor1, instructor2 };
        }
        public void Add(Instructor t)
        {
            instructors.Add(t);
        }

        public void Delete(Instructor t)
        {
            instructors.Remove(t);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetByID(int id)
        {
            return instructors.FirstOrDefault(i => i.InstructorID == id);
        }

        public void Update(Instructor t)
        {
            Instructor existingInstructor = instructors.FirstOrDefault(i => i.InstructorID == t.InstructorID);

            if (existingInstructor != null)
            {
                existingInstructor.InstructorID = t.InstructorID;
                existingInstructor.FirstName = t.FirstName;
                existingInstructor.LastName = t.LastName;
            }
            else
            {
                throw new ArgumentException("Güncellenecek eğitmen bulunamadı.");
            }
        }
    }
}

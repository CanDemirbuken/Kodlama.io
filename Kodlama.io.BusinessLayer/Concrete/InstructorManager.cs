using Kodlama.io.BusinessLayer.Abstract;
using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.BusinessLayer.Concrete
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDAL _ınstructorDAL;

        public InstructorManager(IInstructorDAL ınstructorDAL)
        {
            _ınstructorDAL = ınstructorDAL;
        }

        public void Add(Instructor t)
        {
            _ınstructorDAL.Add(t);
        }

        public void Delete(Instructor t)
        {
            _ınstructorDAL.Delete(t);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDAL.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _ınstructorDAL.GetByID(id);
        }

        public void Update(Instructor t)
        {
            _ınstructorDAL.Update(t);
        }
    }
}

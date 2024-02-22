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
    public class CourseManager : ICourseService
    {
        ICourseDAL _courseDal;

        public CourseManager(ICourseDAL courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course t)
        {
            _courseDal.Add(t);
        }

        public void Delete(Course t)
        {
            _courseDal.Delete(t);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetByID(id);
        }

        public void Update(Course t)
        {
            _courseDal.Update(t);
        }
    }
}

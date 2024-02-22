using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccessLayer.Concrete
{
    public class CourseDAL : ICourseDAL
    {
        List<Course> courses;
        public CourseDAL()
        {
            Course course1 = new Course
            {
                CourseID = 1,
                CategoryID = 1,
                InstructorID = 1,
                Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
                Description = "Engin Demiroğ ile Senior Yazılım Yetiştirme Kampı.",
                CompletionRate = 75
            };

            Course course2 = new Course
            {
                CourseID = 2,
                CategoryID = 1,
                InstructorID = 1,
                Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)",
                Description = "Engin Demiroğ ile Yazılım Geliştirici Yetiştirme Kampı. Angular ve C# öğreniyoruz.",
                CompletionRate = 65
            };

            Course course3 = new Course
            {
                CourseID = 3,
                CategoryID = 1,
                InstructorID = 2,
                Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
                Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CompletionRate = 80
            };

            Course course4 = new Course
            {
                CourseID = 4,
                CategoryID = 1,
                InstructorID = 1,
                Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
                Description = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CompletionRate = 70
            };

            Course course5 = new Course
            {
                CourseID = 5,
                CategoryID = 1,
                InstructorID = 1,
                Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                Description = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CompletionRate = 60
            };

            Course course6 = new Course
            {
                CourseID = 6,
                CategoryID = 1,
                InstructorID = 1,
                Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
                Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CompletionRate = 55
            };

            Course course7 = new Course
            {
                CourseID = 7,
                CategoryID = 1,
                InstructorID = 1,
                Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                CompletionRate = 70
            };

            Course course8 = new Course
            {
                CourseID = 8,
                CategoryID = 1,
                InstructorID = 1,
                Name = "Programlamaya Giriş için Temel Kurs",
                Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.",
                CompletionRate = 65
            };

            courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };
        }
        public void Add(Course t)
        {
            courses.Add(t);
        }

        public void Delete(Course t)
        {
            courses.Remove(t);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetByID(int id)
        {
            return courses.FirstOrDefault(c => c.CourseID == id);
        }

        public void Update(Course t)
        {
            Course existingCourse = courses.FirstOrDefault(c => c.CourseID == t.CourseID);

            if (existingCourse != null)
            {
                existingCourse.CourseID = t.CourseID;
                existingCourse.CategoryID = t.CategoryID;
                existingCourse.InstructorID = t.InstructorID;
                existingCourse.Name = t.Name;
                existingCourse.Description = t.Description;
                existingCourse.CompletionRate = t.CompletionRate;
            }
            else
            {
                throw new ArgumentException("Güncellenecek kurs bulunamadı.");
            }
        }
    }
}

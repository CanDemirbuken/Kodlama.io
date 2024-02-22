using Kodlama.io.BusinessLayer.Concrete;
using Kodlama.io.DataAccessLayer.Concrete;
using Kodlama.io.Entities.Concrete;

namespace Kodlama.io.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Manager Start
            CategoryManager categoryManager = new(new CategoryDAL());
            InstructorManager instructorManager = new(new InstructorDAL());
            CourseManager courseManager = new(new CourseDAL());
            // Create Manager End


            // Listing Start
            List<Category> categories = categoryManager.GetAll();

            foreach (Category item in categories)
            {
                // Entities katmanında ToString methodunu override ettiğim için ToString'i bu şekilde kullandım.
                Console.WriteLine(item.ToString());
            }

            List<Instructor> instructors = instructorManager.GetAll();

            foreach (Instructor item in instructors)
            {
                Console.WriteLine(item.ToString());
            }

            List<Course> courses = courseManager.GetAll();

            foreach (Course item in courses)
            {
                Console.WriteLine(item.ToString());
            }
            // Listing End

            // Get By Id Start
            var result = courseManager.GetById(4);
            Console.WriteLine(result.ToString());
            // Get By Id End

            // Add Method Start
            Category category = new Category
            {
                CategoryID = 10,
                CategoryName = "Test",
            };

            categoryManager.Add(category);
            Console.WriteLine(category.ToString());
            // Add Method End

            // Update Method Start
            var data = instructors.FirstOrDefault(c => c.InstructorID == 2);
            if (data != null)
            {
                data.FirstName = "Halit";
                instructorManager.Update(data);
                Console.WriteLine(data.ToString());

            }
            // Update Method End

            // Delete Method Start
            var data2 = categories.FirstOrDefault(c => c.CategoryID == 1);
            if (data2 != null)
            {
                categoryManager.Delete(data2);
                foreach (Category item in categories)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            // Delete Method End

        }
    }
}

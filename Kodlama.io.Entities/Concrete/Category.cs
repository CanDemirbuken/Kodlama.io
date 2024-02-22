using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return $"Category ID: {CategoryID} - Category Name: {CategoryName}";
        }
    }
}

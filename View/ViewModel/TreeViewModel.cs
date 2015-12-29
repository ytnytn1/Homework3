using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class TreeViewModel : ViewModelBase
    {
        
        public List<Department> Departments { get; set; } = new List<Department>
        {
            new Department {DepartmentName = "Department 1"},
            new Department {DepartmentName = "Department 2"}
        };

        public List<Course> Courses { get; set; } = new List<Course>
        {
             new Course {CourseName = "Course1"},
             new Course {CourseName = "Course2"}
        };
    }
}


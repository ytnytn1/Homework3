using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class CourseViewModel : ViewModelBase
    {
       
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book{BookName = "Gddgfd"},
            new Book{BookName = "HJJHJHGHJ"},
            new Book{BookName = "IGHG"}
        };
        
    }
}

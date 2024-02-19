using Intro.DataAccess.Abstract;
using Intro.Entities___VT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
         List<Course> courses;
        //ctor consturctor oluşturur
        public CourseDal()
        {
            Console.WriteLine("courseDal başladı...");//Eski courseManager
            //constructer blok. Bu class newlendiğinde çalışır.
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".Net 8...";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "java 17";
            course2.Price = 0;

            courses =new List<Course>() {course1,course2};
        }
        public List<Course> getAll()
        {
            //sql öğrenmeli.(Biliyorum)
            //db access implements
            return courses;
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}

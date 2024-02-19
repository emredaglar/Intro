using Intro.DataAccess.Abstract;
using Intro.DataAccess.Concrete;
using Intro.Entities___VT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Bussines_Op_Mt;

public class CourseManager
{
    //operasyon tutucu sınıf. operasyonda ürünleri listelemek. getall ile

    //dependency enjection
    //sadece bu sınıfta kullanılabilir-ve sadece okunabilir
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //bussiness rules yazılcak
        CourseDal courseDal = new CourseDal();

        return _courseDal.getAll();
        //normalde veri kaynağından çekilir.
        // Console.WriteLine("Kurslar Listelendi");

       
    }
}

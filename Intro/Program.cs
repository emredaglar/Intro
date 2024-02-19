// See https://aka.ms/new-console-template for more information
using Intro.Bussines_Op_Mt;
using Intro.DataAccess.Concrete;
using Intro.Entities___VT;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount=1000000;

//veraibles--> camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);


string[] leans = {"kredi 1", "kredi2" };

for (int i = 0; i < leans.Length; i++)
{
    Console.WriteLine(leans[i]);
}

if (isAuthenticated==true)
{
    Console.WriteLine("Buton--> Hoşgeldin Emre");
}
else
{
    Console.WriteLine("Sisteme Giriş Yap");

}





//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
//}

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

for (int i = 0;i < courses.Count; i++) {

    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}


Console.WriteLine("Kod Bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "1312412";
customer1.FirstName="Emre";
customer1.LastName = "Dağlar";
customer1.CustomerNumber = "1212";

BaseCustomer[] customers = { customer1 };

foreach(BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
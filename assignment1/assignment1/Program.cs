
using assignment1.Data;
using assignment1.Data.Models;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using ITIDbContext iti = new ITIDbContext();
             
            Student student01 = new Student() { FName="mohamed",LName="ahmed", Address="cairo", Age=21 };
            Student student02= new Student() {  FName = "sama", LName = "ahmed", Address = "cairo", Age = 23 };
            Student student03 = new Student() { FName = "rana", LName = "ahmed", Address = "cairo", Age = 20 };

            //iti.Add(student01);
            //iti.Add(student02);
            //iti.Add(student03);
            //iti.SaveChanges();
            //Console.WriteLine(iti.Entry(student01).State);
            //Console.WriteLine(iti.Entry(student02).State);
            //Console.WriteLine(iti.Entry(student03).State);

            var s2 = iti.Students.FirstOrDefault(s => s.Id == 2);
            if(s2 is not null)
            iti.Remove(s2);
            iti.SaveChanges();

            Console.WriteLine(iti.Entry(student01).State);
            Console.WriteLine(iti.Entry(student02).State);
            Console.WriteLine(iti.Entry(student03).State);

        }
    }
}

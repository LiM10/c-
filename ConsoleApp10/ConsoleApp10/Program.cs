using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Group p201 = new Group("p201", "14:00 - 18:00", "Saturday 10:00 - 12:00", 2);
            Group p101 = new Group("p201", "9:00 - 13:00", "Saturday 12:00 - 14:00", 4);
            Group p301 = new Group("p201", "19:00 - 22:00", "Saturday 14:00 - 16:00", 5);
            CodeAcademy.AddGroup(p201);
            CodeAcademy.AddGroup(p101);
            CodeAcademy.AddGroup(p301);
            Student Emrah = new Student("Emrah", "Ismayilzade", p201);
            Student Kamran = new Student("Kamran", "Memmedli", p201);
            Student Elxan = new Student("Elxan", "Quliyev", p201);
            Student Murad = new Student("Murad", "Patel", p101);
            Student Eli = new Student("Eli", "Idmanci", p101);
            Student Rehim = new Student("Rehim", "Vorzakon", p101);
            Student Memmed = new Student("Memmed", "Memmedov", p301);
            Student Hesen = new Student("Hesen", "Tagiyev", p301);
            Student Tagi = new Student("Tagi", "Ehmedzade", p301);

            for (int i = 0; i < p201.Students.Count; i++)
            {
                Console.WriteLine(p201.Students[i].Name + " " + p201.Students[i].Surname);
            }
           
            for (int i = 0; i < p101.Students.Count; i++)
            {
                Console.WriteLine(p101.Students[i].Name + " " + p101.Students[i].Surname);
            }

            for (int i = 0; i < p301.Students.Count; i++)
            {
                Console.WriteLine(p301.Students[i].Name + " " + p301.Students[i].Surname);
            }

            Emrah.SendEmail();

        }
    }
}

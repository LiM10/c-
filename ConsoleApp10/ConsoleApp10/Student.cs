using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    public class Student
    {
        public string Name;
        public string Surname;
        public Group Group;

        public Student(string name, string surname, Group group)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
            this.Group.AddStudent(this);
        }

        public void SendEmail()
        {
            Console.WriteLine("Sizin ders saatiniz:" + " " + Group.LessonHour);
            Console.WriteLine("Sizin lab saatiniz:" + " " + Group.LabHour);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    public class Group
    {
        public string GroupName;
        public string LessonHour;
        public string LabHour;
        public List<Student> Students;
        public int maxStudentNumber;

        public Group(string groupname, string lessonhour, string labhour, int maxstudentno)
        {
            this.GroupName = groupname;
            this.LessonHour = lessonhour;
            this.LabHour = labhour;
            this.maxStudentNumber = maxstudentno;
            Students = new List<Student>();

        }

        

        public void AddStudent(Student student1)
        {
            if (Students.Count == maxStudentNumber)
            {
                Console.WriteLine("Yer yoxdu qaqa.");
            }
            else
            Students.Add(student1);
        }


    }
}
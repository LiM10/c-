using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    public static class CodeAcademy
    {
        public static List<Group> Groups;

        static CodeAcademy()
        {
            Groups = new List<Group>();
        }

        public static void AddGroup(Group group)
        {
            Groups.Add(group);
        }


    }
}
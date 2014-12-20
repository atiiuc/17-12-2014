using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Student_InfoApp
{
    class Student
    {
        public string reg;
        public string firstname;
        public string lastname;

        public String getFullname(string firstname,string lastname)
        {
            return firstname + " " + lastname;
        }

    }
}

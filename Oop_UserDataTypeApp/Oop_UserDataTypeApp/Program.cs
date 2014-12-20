using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_UserDataTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyType ob=new MyType();
            ob.name = "Mouse";
            ob.unitPrice = 400;

            MyType ob1=new MyType();
            ob1.name = ob.name;
            ob1.unitPrice = ob.unitPrice;
            Console.WriteLine(ob1.name);
            Console.ReadLine();
        }
    }
}

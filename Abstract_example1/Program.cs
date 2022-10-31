using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_example1
{
    public abstract class Program
    {
        public abstract void absmethod();

        public void aaa()
        {
            string name;
        }
       
    }
    public class program1:Program
    {
        public override void absmethod()
        {
            Console.WriteLine("Implementing abstract method in derived class");
        }
        public void aaa()
        {
            string name = "vinay";
            Console.WriteLine(name);
        }
        public static void Main()
        {
            program1 p1 = new program1();
            p1.absmethod();
            p1.aaa();
            Console.ReadLine();
        }
    }
    //public class mainaa
    //{
       
    //}
}

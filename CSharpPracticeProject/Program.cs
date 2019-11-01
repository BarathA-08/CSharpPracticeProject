using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeProject
{
    internal struct SampleStruct
    {
        private int Number;
        private string Name;

        
        internal SampleStruct(int no, string name)
        {
            Number = no;
            Name = name;
        }

        internal void fun_Display()
        {
            Console.WriteLine("Number: {0}", Number);
            Console.WriteLine("Name: {0}", Name);
        }
    }
    internal class Program
    {
        private protected int i = 10;

        protected internal void fn_Disp()
        {

        }
        static void Main(string[] args)
        {
            int i = 0xAB;
            char c = '\a';
            Console.WriteLine("i: {0},{1}", i, 0xFFFF);
            Console.Write(c);

            Program p = new Program();
            Console.WriteLine(p.i); 
            string s = "Its a Sring";
            var a = s.GetType();
            Console.WriteLine(s.ToUpper());
            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
            Console.Read();

            SampleStruct ss = new SampleStruct(5, "asdF");

        }

    }
}


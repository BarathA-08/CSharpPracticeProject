using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeProject
{
    class CGetandSet
    {
        float _Intvar;
        protected string _StrVar;

        void m1() { }

        public float Intvar
        {
            //get { return _Intvar; }
            //set { _Intvar = value; }
            get;
            set;
        }

        public string StrVar
        {
            //get { return _StrVar; }
            //set { _StrVar = value; }
           get;
           set;
        }

        public CGetandSet(float FltVal, string StrVal)
        {
            _Intvar = FltVal;
            _StrVar = StrVal;

        }

    }

    class CGetandSetImplement
    {
        static void Main()
        {
            CGetandSet cs1 = new CGetandSet(99.99f,"Its a String");
            // cs1.Intvar = 99.99f;
            cs1.Intvar = 199.123f;
            cs1.StrVar = "Changed";      
            Console.WriteLine(cs1.Intvar);
            Console.WriteLine(cs1.StrVar);
            Console.Read();

            //CGetandSetImplement bn = new CGetandSetImplement();
            //bn.StrVar = "changed";



        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeProject
{
    class Rough
    {
        private int n;

        public void fnSetValue(int n)
        {
		this.n = n;
        }
        public int fnReturnValue()
        {
            return this.n;
        }

        static void Main(string[] ss)
        {
            SampleStruct s = new SampleStruct();
            s.fun_Display();
        }
    }

    class cRoughTest
    {
        public void mRoughMethod()
        {
            Rough r = new Rough();
            r.fnSetValue(10);
            r.fnReturnValue();
            
            
        }
    }

}

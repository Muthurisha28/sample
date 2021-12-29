using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_28_12
{
    class Class1
    {
        public int a0, b0;
        public int GetSecondLargest(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a0)
                {
                    b0 = a0;
                    a0 = a[i];
                }
                else if (a[i] > b0) b0 = a[i];
            }
            return b0;


        }

    }

}


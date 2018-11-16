using System;
using System.Net;

namespace DebugPackagePoC
{
    public class SimpleFunctions
    {
        public int MultiplyIntegers(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < a; i++)
            {
                result += b;
            }

            return result;
        }
    }
}

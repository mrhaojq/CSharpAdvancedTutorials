using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExtensionMethod
{
    public static class MyStringExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] {' ','.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

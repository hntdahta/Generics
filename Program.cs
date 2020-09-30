using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> generic = new Generic<int>();
            generic.Compare<int>(2, 2);
            generic.Compare<string>("abc", "abc");

        }
    }

}
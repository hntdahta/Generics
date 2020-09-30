using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
     class Generic<T>
    {
        public T a { get; set; }
        public T b { get; set; }
        public void Compare<T>(T a, T b)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (a.Equals(b))
            {

                Console.WriteLine($"Hai giá trị bằng nhau ({a} = {b})");
            }
            else
            {

                Console.WriteLine($"Hai giá trị không bằng nhau ({a} != {b})");
            }
        }
    }
}

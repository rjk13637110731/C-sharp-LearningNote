using System;
namespace proj2_1 {
    class program { 
        static void Main(string[] args)
        {
            int i = 65, i1, i2;
            double d = 66.3456, d1, d2;
            char c = 'A', c1, c2;
            Console.WriteLine("i1 = {0:d5},d = {1:f},c = {2}",i,d,c);

            i1 = (int)d;
            d1 = i;
            c1 = (char)i;
            Console.WriteLine("i2 = {0:d5},d1 = {1:f},c1 = {2}", i1, d1, c1);
;           i2 = c;
            d2 = (int)d;
            c2 = (char)d;
            Console.WriteLine("i2 = {0:d5},d2 = {1:f},c2 = {2}", i2, d2, c2);
        }
    }
}

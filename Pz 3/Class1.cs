using System;
using System.Collections.Generic;
using System.Text;

namespace Pz_3
{
    class FuzzyNuber
    {
        private int _a1;
        private int _b1;
        private int _a2;
        private int _b2;
        private int _A;
        private int _B;
        public FuzzyNuber(int first, int second,int three, int four, int one , int two)
        {
            _a1= first;
            _b1= second;
            _a2 = three;
            _b2 = four;
            _A = one;
            _B = two;
        }
        public FuzzyNuber()
        {

        }
        public void Read()
        {
            _a1 = Convert.ToInt32(Console.ReadLine());
            _b1 = Convert.ToInt32(Console.ReadLine());
            _a2 = Convert.ToInt32(Console.ReadLine());
            _b2 = Convert.ToInt32(Console.ReadLine());
            _A = Convert.ToInt32(Console.ReadLine());
            _B = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("");
            Console.WriteLine(""+_a1+ _a2 +_b1 + _b2 + _A + _B);
        }
    }
}

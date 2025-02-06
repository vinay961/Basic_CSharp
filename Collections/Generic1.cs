using System;

namespace Collections
{
    class Generic1
    {
        public void Add<T>(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            Console.WriteLine(dx + dy);
        }
        public void Sub<T>(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            Console.WriteLine(dx - dy);
        }
        public void Mul<T>(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            Console.Write(dx * dy);
        }

        static void Main(string[] args)
        {
            Generic1 obj = new Generic1();
            obj.Add(1,2);  
        }
    }
}

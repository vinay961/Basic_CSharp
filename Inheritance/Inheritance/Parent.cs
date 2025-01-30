
namespace Inheritance
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent constructor");
        }
        public virtual void method1()
        {
            Console.WriteLine("Parent method1");
        }
        public void method2()
        {
            Console.WriteLine("Parent method2");
        }
    }
}

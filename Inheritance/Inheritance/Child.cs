
namespace Inheritance
{
    class Child : Parent
    {
        public override void method1()
        {
            Console.WriteLine("Child method1");
        }
        public void method3()
        {
            Console.WriteLine("Child method3");
        }
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.method1();
            p.method2();
            //p.method3();
        }
    }
}
// If the parent class constructor is private, the child class will not be able to access it and hence inheritance is not possible.
// In inheritance, the child class inherits the properties and behavior of the parent class, but parent class can not inherit the properties and behavior of the child class.
// We can initialize a parent class variable using a child class object, but the reverse is not possible. ( Parent p = new Child(); )
// In the above code, the output for p.method3() will be an error because the parent class does not have a method3() method.
// For accessing the method3() method, we need to create an object of the child class. ( Child c = new Child(); c.method3(); )
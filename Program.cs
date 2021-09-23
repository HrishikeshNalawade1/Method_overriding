using System;

namespace method_overiding
{
    class Dog
    {
        public virtual void  walk()
        {
            Console.WriteLine("Dog is walking");
        }
    }
    class cat:Dog
    {
        public override void walk()
        {
            Console.WriteLine("Cat is walking");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //cat obj = new cat();
            //obj.walk();
            Dog obj = new Dog();
            obj.walk();
            obj = new cat();
            obj.walk();
        }
        
    }
}

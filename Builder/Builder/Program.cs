using System;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Car car = new Car();
            //car.drive().breaking().drive(); //chain method call

            //TaskA cb1 = new TaskA();
            //cb1.createId(1).createPart2();

            //TaskB myTask = new TaskB();
            //myTask.createId(2).createPart2();

            Director d = new Director();
            IBuilder ta1 = d.build("A").createId(1).createPart2().reset();
            ta1.createId(34);
            IBuilder ta2 = d.build("A").createId(2).createPart2();
            IBuilder ta3 = d.build("B").createId(1).createPart2();

            ImmutableClass ic = new ImmutableClass("my note 1");
            ic = new ImmutableClass("new note");
            ic.getNote();

            Console.ReadKey();
        }
    }
}

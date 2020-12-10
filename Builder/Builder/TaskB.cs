using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class TaskB : IBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IBuilder createId(int id)
        {
            this.Id = id;
            Console.WriteLine("My id: " + this.Id);
            return this;
        }

        public IBuilder createPart2()
        {
            this.Name = "New Task";
            Console.WriteLine("My name: " + this.Name);
            return this;
        }

        public IBuilder reset()
        {
            return new TaskB();
        }

        public TaskB getProduct()
        {
            Console.WriteLine("My id: " + this.Id + "My Name" + this.Name);
            return this;
        }
    }
}

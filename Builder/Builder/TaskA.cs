using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TaskA : IBuilder
    {
        MyTask thisTask;
        public int Id { get; set; }
        public int Number { get; set; }

        public IBuilder createId(int id)
        {
            this.Id = id;
            Console.WriteLine("My id: " + this.Id);
            return this;
        }

        public IBuilder createPart2()
        {
            this.Number = 100;
            Console.WriteLine("My number: " + this.Number);
            return this;
        }

        public IBuilder reset()
        {
            return new TaskA();// it is just an initialization, we want new TaskA
        }

        public void getProduct()
        {
            //Console.WriteLine("My id: " + this.Id + "My Number" + this.Number);
            //return this;
            thisTask = new MyTask(1);
        }
    }
}

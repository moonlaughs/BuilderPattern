using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class MyTask
    {
        public MyTask(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

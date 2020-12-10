using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder build(string myTask)
        {
            if (myTask == "A")
                builder = new TaskA().createPart2(); //we choose what we initialize


            else {
                //TaskB().getProduct();
                builder = new TaskB();
            }

            return builder;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        //in abstract class it would be having instance field for protected MyTask myTask;

        public IBuilder reset();
        public IBuilder createId(int id);
        public IBuilder createPart2();
    }
}

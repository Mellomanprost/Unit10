using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10._2._4
{
    public interface IWorker
    {
        void Build();
    }
    public class Worker: IWorker
    {
        void IWorker.Build()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorker)worker).Build();
        }
    }
}

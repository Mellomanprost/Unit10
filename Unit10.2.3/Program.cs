using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10._2._3
{
    public interface IWorker
    {
        void Build();
    }
    public class Worker: IWorker
    {
        public void Build()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Build();
        }
    }
}

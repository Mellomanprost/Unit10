using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10._2
{
    public interface IWriter
    {
        void Write();
    }
    public class Writer : IWriter 
    {
        void IWriter.Write()
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

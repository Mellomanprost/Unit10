using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public interface IBook
        {
            void Read();
        }

        public interface IDevice
        {
            void TurnOn();
            void TurnOff();
        }

        public class ElectronicBook : IBook, IDevice
        {
            void IBook.Read()
            {
                throw new NotImplementedException();
            }

            void IDevice.TurnOff()
            {
                throw new NotImplementedException();
            }

            void IDevice.TurnOn()
            {
                throw new NotImplementedException();
            }
        }
    }
}

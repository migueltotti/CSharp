
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_motivador_1.Services
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;
        public void addValue(T value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T first()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void print()
        {
            int i = 0;
            Console.Write("[");
            for (i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }

            if(i == _count - 1)
            {
                Console.Write(_values[i]);
            }

            Console.WriteLine("]");
        }
    }
}

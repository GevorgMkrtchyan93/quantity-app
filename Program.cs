using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Quantity ships = new Quantity();

            foreach (int item in ships)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public class Quantity : IEnumerable
        {
            protected int[] ships = new int[] { 40, 90, 120, 37 };
            public IEnumerator GetEnumerator()
            {
                return new QuantityIEnumerator(ships);
            }
        }
        public class QuantityIEnumerator : IEnumerator
        {
            private int[] _ships;
            private int count = 0;
            public QuantityIEnumerator(int[] ships)
            {
                _ships = ships;
            }
            public object Current => _ships[count++];

            public bool MoveNext()
            {
                return count < _ships.Length;
            }
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
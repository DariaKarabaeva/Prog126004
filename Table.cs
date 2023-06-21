using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2047
{
    class Table
    {
        public int size { get; private set;}

        int[,] table;
        public Table(int size) 
        { 
            this.size = size;
            table = new int [size, size];
        }
        public int Get(int x, int y)
        {
            if (x >= 0 && x < 4 &&
                y >= 0 && x < 4)
                return table[x, y];
            return -1;
        }
        public void Set(int x, int y, int number)
        {
            if (x >= 0 && x < 4 &&
                y >= 0 && x < 4)
                table[x, y] = number;
        }
    }
}

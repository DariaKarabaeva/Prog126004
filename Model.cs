using System;
using System.Data.Common;
using System.Drawing;

namespace Exam2047
{
    public class Model
    {
        public int size { get { return table.size; } }
        Table table;
        bool isGameOver;
        bool Moved;
        static Random random = new Random();
        public Model (int size) 
        {
            table = new Table(size);
        }
        public void Start()
        {
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                    table.Set(x, y, 0);
            AddRandomNumber();
            AddRandomNumber();
        }
        private void AddRandomNumber()
        {
            if (isGameOver) return;
            for (int j = 0; j < 100; j++)
            {
                int x = random.Next(0, 4);
                int y = random.Next(0, 4);
                if (table.Get(x, y) == 0)
                {
                    table.Set(x, y, random.Next(1, 3) * 2);
                    return;
                }

            }
        }
        void Lift(int x, int y, int sx, int sy)
        {
            if (table.Get(x, y) > 0)
                while (table.Get(x + sx, y + sy) == 0)
                {
                    table.Set(x + sx, y + sy, table.Get(x, y));
                    table.Set(x, y, 0);
                    x += sx;
                    y += sy;
                }
        }
        void Join(int x, int y, int sx, int sy)
        {
            if (table.Get(x, y) > 0)
                if (table.Get(x + sx, y + sy) == table.Get(x, y))
                {
                    table.Set(x + sx, y + sy, table.Get(x, y) * 2);
                    while (table.Get(x - sx, y - sy) > 0)
                    {
                        table.Set(x, y, table.Get(x - sx, y - sy));
                        x -= sx;
                        y -= sy;
                    }
                    table.Set(x, y, 0);
                }
        }
        public void Left()
        {
            for (int y = 0; y < 4; y++)
                for (int x = 1; x < 4; x++)
                    Lift(x, y, -1, 0);
            for (int y = 0; y < 4; y++)
                for (int x = 1; x < 4; x++)
                    Join(x, y, -1, 0);
            AddRandomNumber();
        }
        public void Right()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 4 - 2; x >= 0; x--)
                    Lift(x, y, +1, 0);
                for (int x = 4 - 2; x >= 0; x--)
                    Join(x, y, +1, 0);

            }
            AddRandomNumber();
        }
        public void Up()
        {
            for (int x = 0; x < 4; x++)
                for (int y = 1; y < 4; y++)
                    Lift(x, y, 0, -1);
            for (int x = 0; x < 4; x++)
                for (int y = 1; y < 4; y++)
                    Join(x, y, 0, -1);
            AddRandomNumber();
        }
        public void Down()
        {
            for (int x = 0; x < 4; x++)
                for (int y = 4 - 2; y >= 0; y--)
                    Lift(x, y, 0, +1);
            for (int x = 0; x < 4; x++)
                for (int y = 4 - 2; y >= 0; y--)
                    Join(x, y, 0, +1);
            AddRandomNumber();
        }
        public int Getlocation(int x, int y)
        {
            return table.Get(x, y);
        }
    }
}

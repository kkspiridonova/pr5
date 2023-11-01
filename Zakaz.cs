using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Торты
{
    internal class Zakaz
    {
        private int minstr;
        private int maxstr;
        public Zakaz(int min, int max)
        {
            minstr = min;
            maxstr = max;
        }
        public int Show()
        {
            int pos = 1;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos!=minstr)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos!=maxstr)
                {
                    pos++;
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}

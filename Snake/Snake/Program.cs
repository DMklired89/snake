using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1; 
            int y1 = 3;
            char sym1 = '*';  // показать на экране символ "*"

            Draw(x1, y1, sym1);  // отобразить на экране при помощи функции Draw
        
            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);

            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym) // функция - вывод точек с координатами x,y на экран
        {
            Console.SetCursorPosition(x, y); // показать на экране координаты
            Console.Write(sym);               // показать на экране символ "*" 
        }
    }
}

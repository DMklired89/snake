using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point            // Создали класс для "точки" на экране
    {
        public int x;      // Логически объединены 
        public int y;      // три переменные
        public char sym;   // в новый тип данных 

        public void Draw()
        {
            Console.SetCursorPosition(x, y);  // показать на экране координаты
            Console.Write(sym);               // показать на экране символ "*"
        }
    }
}

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

        public Point()     // Функция коструктор (называется как класс и не имеет возвращаемого значения) 
        {
        }

        public Point(int _x, int _y, char _sym)   
        {
            x = _x;
            y = _y;
            sym = _sym;
        }   
        
        public void Draw()   // Draw тоже ничего не возвращает, но это прописывается за счет void 
        {
            Console.SetCursorPosition(x, y);  // показать на экране координаты
            Console.Write(sym);               // показать на экране символ "*"
        }
    }
}

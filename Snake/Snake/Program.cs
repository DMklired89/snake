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
            Point p1 = new Point (1, 3,'*');       // экземпляр (объект)  классa Point       
            p1.Draw();         // Вывод точки на экран при помощи функции Draw (при таком выводе обязательно
                               // обознать функцию Draw в классе Point)

            Point p2 = new Point(4, 5, '#');  // В данной реализации использована инкапсуляция - детали реализвции        
            p2.Draw();                        // скрыты здесь, а прописаны в классе Point: в том числе и то, как 
                                              // точка выводится на экран

            Console.ReadLine();   // закрытие консоли при нажатии"Enter"
        }
    }
}

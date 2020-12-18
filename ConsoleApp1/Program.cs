using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class MainClass 
    {
        public static void Main(string[] agrs)
        {
            //Console.WriteLine("[" + DateTime.Now + "] " + "Hello, " + name + "!");//

            Console.WriteLine("Hello, enter you name:");
            String name = Console.ReadLine();
            //Console.WriteLine($"helo? {name}!";//
            Console.WriteLine("[" + DateTime.Now + "] " + "Hello, " + name + "!"); //добавляет Дату и время + привет + имя
            Console.ReadKey(); // ждать эникея пользователя.
        }
    }
}

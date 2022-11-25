using System;
using System.Windows;
using System.Collections.Generic;

namespace tumakov
{
    class Program
    {


        static void Main(string[] args)
        {
            ex1();
        }

 

        static void ex1()
        {
            Console.WriteLine("Создать интерфейс ICipher, который определяет методы поддержки шифрования строк." +
                "В интерфейсе объявляются два метода encode() и decode(), которые используются для шифрования и дешифрования строк, соответственно." +
                "Создать класс ACipher, реализующий интерфейс ICipher.Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше." +
                "Например, в результате такого сдвига буква А становится буквой Б. Создать класс BCipher, реализующий интерфейс ICipher." +
                "Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i - й позиции, на букву того же регистра, " +
                "расположенную в алфавите на i - й позиции с конца алфавита.Например, буква В заменяется на букву Э.");
            Byte num;
            do
            {
                Console.WriteLine("Choose needed operation");
                Console.WriteLine("1 - code (ACipher)");
                Console.WriteLine("2 - decode (ACipher)");
                Console.WriteLine("3 - code (BCipher)");
                Console.WriteLine("4 - decode (BCipher)");
                while (!Byte.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Wrong enter. Please try again");
                }

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter the string you want to code");
                        string str = Console.ReadLine();
                        ACipher.ICipher.encode(str);
                        continue;

                    case 2:
                        Console.WriteLine("Enter the string you want to decode");
                        string str2 = Console.ReadLine();
                        ACipher.ICipher.decode(str2);
                        continue;

                    case 3:
                        Console.WriteLine("Enter the string you want to code");
                        string str3 = Console.ReadLine();
                        BCipher.encode(str3);
                        continue;

                    case 4:
                        Console.WriteLine("Enter the string you want to decode");
                        string str4 = Console.ReadLine();
                        BCipher.decode(str4);
                        continue;

                    default:
                        Console.WriteLine("Sorry, you are dumber that your laptop");
                        continue;


                }
            }
            while (num != 0);

        }

        static void ex2()
        {
            Console.WriteLine("Создать класс Figure для работы с геометрическими фигурами.В качестве полей класса задаются цвет фигуры, состояние «видимое / невидимое»." +
                " Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния(видимый / невидимый)." +
                "Метод вывода на экран должен выводить состояние всех полей объекта. Создать класс Point(точка) как потомок геометрической фигуры." +
                "Создать класс Circle(окружность) как потомок точки.В класс Circle добавить метод, который вычисляет площадь окружности.Создать класс Rectangle" +
                "(прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника. Точка, окружность, прямоугольник должны поддерживать методы" +
                "передвижения по горизонтали и вертикали, изменения цвета. Подумать, какие методы можно объявить в интерфейсе, нужно ли объявлять абстрактный класс, " +
                "какие методы и поля будут в абстрактном классе,какие методы будут виртуальными, какие перегруженными.");
            List<Figure> figures = new List<Figure>();
            byte num;
            do
            {
                Console.WriteLine("Choose a figure");
                Console.WriteLine("1 - point ");
                Console.WriteLine("2 - circle");
                Console.WriteLine("3 - rectangle");
                while (!Byte.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Wrong enter. Please try again");
                }

                switch (num)
                {
                    case 1:
                        Point point = new Figure();
                        continue;
                }
            }
            while (num != 0);




        }
    }
}


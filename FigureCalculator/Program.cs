using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Создать классы Point и Figure.
 * 
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. 

Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.

Написать программу, которая выводит на экран название и периметр многоугольника.*/

namespace FigureCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 - 3-gon\n2 - 4-gon\n3 - 5-gon\n      Make a choice: ");
            int choice =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('_', 50));
            Point[] pointArray = new Point[choice];
            string pointName = "ABCDE";
            
            for (int i = 0; i < choice; i++)
            {
                string name = Convert.ToString(pointName[i]);
                Console.WriteLine("Point name: " + name);
                
                Console.Write("=> X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("=> Y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                
                Point point = new Point(x, y, name);  
                pointArray[i] = point;
            }
            if (choice==3)            
            {   
                Console.WriteLine("TRIANGLE");
                Figure figure = new Figure(pointArray[0], pointArray[1], pointArray[2]);
                figure.PerimeterCalculator();
            }
            if (choice == 4)
            {
                Console.WriteLine("QUADRILATERAL");
                Figure figure = new Figure(pointArray[0], pointArray[1], pointArray[2], pointArray[3]);
                figure.PerimeterCalculator();
            }
            if(choice == 5)
            {
                Console.WriteLine("PENTAGON");
                Figure figure = new Figure(pointArray[0], pointArray[1], pointArray[2], pointArray[3], pointArray[4]);
                figure.PerimeterCalculator();
            }
            
            Console.ReadLine();
        }
    }
}

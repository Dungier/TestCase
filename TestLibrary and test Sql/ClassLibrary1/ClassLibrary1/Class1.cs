using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
    public class Circles
    {
        static public double Circle(int Radius)
        {
            double ans = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            return ans;
        }
    }
    public class Triangles
    {
        public static string TriangleType(int a, int b, int c)
        {
            string ans = "Ошибка условий";
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)//Проверка на существование треугольника
            {
                if (a == b && a != c || a == c && a != b || b == c && b != a)//Равнобедренный
                {
                    ans = "Равнобедренный";
                }
                else if (a == b && b == c)//Равносторонний
                {
                    ans = "Равносторонний";
                }
                else if (a != b && a != c)//Разносторонний
                {
                    ans = "Разносторонний";
                }
            }
            else if (a + b == c || a + c == b || b + c == a)
            {
                ans = "треугольник вырожденый";
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                ans = "Сторона 0";
            }
            return ans;
        }
        public static double TriangleS(int a, int b, int c)
        {
            double ans = 0;
            double p = 0;
            p = (a + b + c) / 2;
            ans = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            if (a == b && b == c)
            {
                ans = Math.Round((Math.Sqrt(3) * Math.Pow(a, 2) / 4), 2);
            }
            if ( (a + b == c || a + c == b || b + c == a) || (a == 0 || b == 0 || c == 0))
            {
                ans = 0;
            }
            return ans;
        }
        //Добавление новой фигуры как можно видеть выше не сложное, просто необходимо создать public static double метод, чтобы получать необходимое значение площади, и уже внутри прописать логику
    }
}

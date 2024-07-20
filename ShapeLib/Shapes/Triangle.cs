using ShapeLib.Exceptions;

namespace ShapeLib.Shapes
{
    public class Triangle : IShape
    {
        public double a, b, c;

        public Triangle(double a, double b, double c)
        {
            CheckTriangleExists(a, b, c);

            this.a = a;
            this.b = b;
            this.c = c;
        }

        // расчёт площади треугольника
        public double GetSquare()
        {
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Math.Round(square, 2);
        }

        // проверка существования треугольника по входным данным
        private void CheckTriangleExists(double a, double b, double c)
        {
            // проверка входных данных на отрицательные значения
            ValidatePositiveValue(a);
            ValidatePositiveValue(b);
            ValidatePositiveValue(c);


            // проверка суммы сторон треугольника, которая показывает, что треугольник существует
            if (a + b > c || a + c > b || b + c > a)
            {
                throw new ArgumentException("Неправильно указан треугольник: такого треугольника не существует");
            }
            // проверка на то, является ли треугольник прямоугольным (про другие типы треугольников в задаче не уточняется)
            if (
                Math.Pow(a, 2) == Math.Pow(c, 2) + Math.Pow(b, 2)
                || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)
                || Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)
                )
            {
                throw new InvalidTriangleException();
            }
        }

        private static void ValidatePositiveValue(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), $"Неправильно указана сторона треугольника: {value}");
            }
        }
    }
}

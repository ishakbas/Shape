namespace ShapeLib.Exceptions
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException() : base("Передан прямоугольный треугольник, ожидался обычный треугольник.") { }
    }
}

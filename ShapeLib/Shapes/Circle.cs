namespace ShapeLib.Shapes
{
    public class Circle : IShape
    {
        private static readonly double PI = Math.PI;
        public double radius;
        public Circle(double radius)
        {
            this.radius =
                radius > 0 ? radius : throw new ArgumentOutOfRangeException(nameof(radius), $"Неправильно указан радиус круга: {radius}");
        }

        public double GetSquare()
        {
            double result = PI * (radius * radius);
            return Math.Round(result, 2);
        }
    }
}

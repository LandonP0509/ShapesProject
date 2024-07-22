namespace ShapesMainApp
{
    public class Circle : Shape
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
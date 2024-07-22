namespace ShapesMainApp
{
    public class Reader
    {
        public static List<Shape> ReadShapesFromFile(string filePath)
        {
            var shapes = new List<Shape>();

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split (' ');
                if (parts [0] == "Rectangle")
                {
                    var width = double.Parse(parts[1]);
                    var height = double.Parse(parts[2]);
                    shapes.Add(new Rectangle(width, height));
                }
                else if (parts[0] == "Circle")
                {
                    var radius = double.Parse(parts[1]);
                    shapes.Add(new Circle(radius));
                }
            }
            return shapes;
        }
    }
}
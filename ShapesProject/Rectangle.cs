namespace ShapesMainApp
{
    public class Rectangle : Shape
    {
        public Rectangle(double width) 
        {
            this.Width = width;
   
        }
        public Rectangle(double width) 
        {
            this.Width = width;
   
        }
                       private double Width { get; }
       private double Height { get; }

       public Rectangle(double width, double height)
       {
        Width = width;
        Height = height;
       } 

       public override double Area()
       {
        return Width * Height;
       }

       public override double perimeter()
       {
        return 2 * (Width + Height);
       }
    }
}


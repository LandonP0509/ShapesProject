using System.Collections.ObjectModel;

namespace ShapesMainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ShapesProjectApp: <input file>");
            return;
        }

        List <Shape> shapes = Reader.ReadShapesFromFile(filePath);

        foreach (var item in Collection)
        {
            
        } NewStructin shapes);
    }

    internal struct NewStruct
    {
        public object shape;
        public object Item2;

        public NewStruct(object shape, object item2)
        {
            this.shape = shape;
            Item2 = item2;
        }

        public override bool Equals(object? obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<object>.Default.Equals(shape, other.shape) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(shape, Item2);
        }

        public void Deconstruct(out object shape, out object item2)
        {
            shape = this.shape;
            item2 = Item2;
        }

        public static implicit operator (object shape, object)(NewStruct value)
        {
            return (value.shape, value.Item2);
        }

        public static implicit operator NewStruct((object shape, object) value)
        {
            return new NewStruct(value.shape, value.Item2);
        }
    }
}
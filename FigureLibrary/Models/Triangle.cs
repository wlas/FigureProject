using FigureLibrary.Models.Base;

namespace FigureLibrary.Models
{
    public class Triangle : Figure
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public double Side1 => _side1;
        public double Side2 => _side2;
        public double Side3 => _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override void Draw()
        {
            Console.WriteLine(@$"Рисуем треугольник, сторона 1: {_side1}, сторона 2: {_side2}, сторона 3: {_side3} и цветом {Color}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Cторона 1: {_side1}, Cторона 2: {_side2}, Cторона 3: {_side3}");
        }
    }
}

using FigureLibrary.Models.Base;

namespace FigureLibrary.Models
{
    public class Quadrilateral : Figure
    {
        private double _side1;
        private double _side2;
        private double _side3;
        private double _side4;
        public double Side1 => _side1;
        public double Side2 => _side2;
        public double Side3 => _side3;
        public double Side4 => _side4;

        public Quadrilateral(double side1, double side2, double side3, double side4)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            _side4 = side4;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем четырехугольник, сторона 1: {_side1}, сторона 2: {_side2}, сторона 3: {_side3}, сторона 4: {_side4} и цветом {Color}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"сторона 1: {_side1}, сторона 2: {_side2}, сторона 3: {_side3}, сторона 4: {_side4}");
        }
    }
}

using FigureLibrary.Models.Base;

namespace FigureLibrary.Models
{
    public class Square : Figure
    {
        private double _side;
        public double Side => _side;

        public Square(double side)
        {
            _side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем квадрат со стороной {_side} и цветом {Color}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Длина стороны: {_side}");
        }
    }
}

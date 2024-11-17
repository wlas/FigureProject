using FigureLibrary.Models.Base;

namespace FigureLibrary.Models
{
    public class Ellipse : Figure
    {
        private double _width;

        private double _height;
        public double Width => _width;
        public double Height => _height;

        public Ellipse(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем эллипс шириной {_width}, высотой {_height} и цветом {Color}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Ширина: {_width} Высота: {_height}");
        }
    }
}

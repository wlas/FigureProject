using FigureLibrary.Models.Base;

namespace FigureLibrary.Models
{
    public class Сircle : Figure
    {
        private double _radius;
        public double Radius => _radius;

        public Сircle(double radius)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом {_radius} и цветом {Color}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {_radius}");
        }
    }
}

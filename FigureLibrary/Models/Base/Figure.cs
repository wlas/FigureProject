using FigureLibrary.Interface;

namespace FigureLibrary.Models.Base
{
    public abstract class Figure : IPrintFigure
    {
        public string Color { get; set; } = "Черный"; // Цвет фигуры
        public abstract void Draw(); // Метод отрисовки

        public virtual void Print()
        {
            Console.WriteLine($"Фигура: {GetType().Name}, Цвет: {Color}");
        }
    }
}

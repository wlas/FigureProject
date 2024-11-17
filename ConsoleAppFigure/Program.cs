using FigureLibrary.Models;
using FigureLibrary.Models.Base;
using FigureLibrary.Services;

var shapes = new List<Figure>
{
            new Сircle(10) { Color = "Красный" },
            new Ellipse(15, 10) { Color = "Синий" },
            new Triangle(3, 4, 5) { Color = "Зеленый" },
            new Square(5) { Color = "Желтный" },
            new Quadrilateral(2, 3, 4, 5) { Color = "Оранжевый" }
        };

var renderer = new FigureRenderer(shapes);
Console.WriteLine("===============");
Console.WriteLine("Отрисовка фигур");
Console.WriteLine("===============");
renderer.RenderAll();
Console.WriteLine("");
Console.WriteLine("============================");
Console.WriteLine("Выводим информацию о фигурах");
Console.WriteLine("============================");

renderer.RenderAll();
using FigureLibrary.Models.Base;

namespace FigureLibrary.Services
{
    public class FigureRenderer
    {
        private readonly List<Figure> _figures;
        public FigureRenderer(List<Figure> figures)
        {
            _figures = figures;
        }

        /// <summary>
        /// Отрисовываем все фигуры из списка
        /// </summary>
        public void RenderAll()
        {
            foreach (var figure in _figures)
            {
                figure.Draw();
            }
        }
        /// <summary>
        /// Выводим информацию о фигурах из списка
        /// </summary>
        public void PrintAll()
        {
            foreach (var figure in _figures)
            {
                figure.Print();
            }
        }
    }
}

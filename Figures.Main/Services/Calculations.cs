using Figures.Main.Models.Base;

namespace Figures.Main.Services
{
    public static class Calculations
    {
        public static double CalculateArea(FigureBase figure) => figure.calculateArea();
    }
}

using Figures.Main.Models.Base;

namespace Figures.Main.Models
{
    public class Circle : FigureBase
    {
        public double Radius { get; }
        public Circle(string name, double radius) : base(name)
        {
            if (radius <= 0) throw new Exception("Rafius must be more then 0");
            Radius = radius;
        }
        public override double calculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

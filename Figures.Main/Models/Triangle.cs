using Figures.Main.Models.Base;

namespace Figures.Main.Models
{
    public class Triangle : FigureBase
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }

        public Triangle(string name, double firstSide, double secondSide, double thirdSide) : base(name)
        {
            if (!isExist(firstSide, secondSide, thirdSide)) throw new Exception("Such triangle cannot exist");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        private bool isExist(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b;
        }
        public override double calculateArea()
        {
            double p = FirstSide + SecondSide + ThirdSide;
            double halfP = p / 2;
            return Math.Sqrt(halfP * (halfP - FirstSide) * (halfP - SecondSide) * (halfP - ThirdSide));
        }
        public bool isSquareTriangle()
        {
            double sqrFirst = Math.Pow(FirstSide, 2);
            double sqrSecond = Math.Pow(SecondSide, 2);
            double sqrThird = Math.Pow(ThirdSide, 2);
            return sqrFirst == sqrSecond + sqrThird || sqrSecond == sqrFirst + sqrThird || sqrThird == sqrFirst + sqrSecond;
        }
    }
}

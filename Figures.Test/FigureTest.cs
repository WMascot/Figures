using Figures.Main.Models;
using Figures.Main.Services;
using System;
using Xunit;

namespace Figures.Test
{
    public class FigureTest
    {
        [Fact]
        public void CircleConstructor_RadiusLessThenZero_ThrowException()
        {
            Action act = () => new Circle("Circle", -1);

            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void TriangleConstructor_OneOfTheSidesISLessThenZero_ThrowException()
        {
            Action act = () => new Triangle("Triangle", -1, 1, 2);

            Assert.Throws<Exception>(act);
        }
        [Fact]
        public void TriangleConstructor_WrongSides_ThrowException()
        {
            Action act = () => new Triangle("Triangle", 3, 5, 1);

            Assert.Throws<Exception>(act);
        }
        [Fact]
        public void CalculateAreaTriangle_InputIs345_Returns6()
        {
            Triangle triangle = new Triangle("Triangle", 3, 4, 5);

            double result = Calculations.CalculateArea(triangle);

            Assert.Equal(6, result);
        }
        [Fact]
        public void IsSquareTriangle_Input345_ReturnsTrue()
        {
            Triangle triangle = new Triangle("Triangle", 3, 4, 5);

            bool result = triangle.isSquareTriangle();

            Assert.True(result);
        }
        [Fact]
        public void IsSquareTriangle_Input346_ReturnsFalse()
        {
            Triangle triangle = new Triangle("Triangle", 3, 4, 6);

            bool result = triangle.isSquareTriangle();

            Assert.False(result);
        }
        [Fact]
        public void CalculateAreaCircle_Input16_Returns804()
        {
            Circle circle = new Circle("Circle", 16);

            double result = Calculations.CalculateArea(circle);
            double expectedResult = Math.PI * 256;

            Assert.Equal(expectedResult, result);
        }
    }
}
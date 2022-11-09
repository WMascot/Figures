using NUnit.Framework;
using Figures.Main.Services;
using Figures.Main.Models.Base;
using Figures.Main.Models;

namespace Figures.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void CircleConstrctor_RadiusLessThen0_ThrowException()
        {
            var result = () => new Circle("Circle", -1);

            Assert.Catch(result, "Rafius must be more then 0");
        }
    }
}
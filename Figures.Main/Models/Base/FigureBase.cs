using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Main.Models.Base
{
    public abstract class FigureBase
    {
        public string Name { get; }
        public FigureBase(string name)
        {
            Name = name;
        }
        public abstract double calculateArea();
    }
}

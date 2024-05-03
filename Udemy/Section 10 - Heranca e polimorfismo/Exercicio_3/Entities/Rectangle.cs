using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_3.Entities.Enums;

namespace Exercicio_3.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Color color, double width, double heigth) : base(color)
        {
            Width = width;
            Height = heigth;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

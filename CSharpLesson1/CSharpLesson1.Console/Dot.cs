using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1.ConsoleApp
{
    public class Dot
    {
        /// <summary>
        /// Color of the dot 
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// Shape of the dot
        /// </summary>
        public Shape Shape { get; set; }
        /// <summary>
        /// Position of the dot
        /// </summary>
        public PlanarPosition Position { get; set; }
        /// <summary>
        /// Diameter of the dot, in millimeters
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// Creates a new instance of the Dot class
        /// </summary>
        public Dot()
        {
        }

        /// <summary>
        /// Creates a new instance of the Dot class
        /// </summary>
        /// <param name="shape">Shape of the Dot</param>
        /// <param name="position">Position of the Dot</param>
        /// <param name="size">Diameter of the Dot, in millimeters</param>
        public Dot(Color color, Shape shape, PlanarPosition position, double size)
        {
            Color = color;
            Shape = shape;
            Position = position;
            Size = size;
        }

        public override string ToString()
        {
            var result =
                "Color: " + Color + "|" +
                "Shape: " + Shape + "|" +
                "Position: " + Position + "|" +
                "Size: " + Size;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1.ConsoleApp
{
    public class PlanarPosition
    {
        /// <summary>
        /// X-Coordinate of a two dimensional position
        /// </summary>
        public double XCoord { get; set; }
        /// <summary>
        /// Y-Coordinate of a two dimensional position
        /// </summary>
        public double YCoord { get; set; }

        /// <summary>
        /// Creates a new instance of a two dimensional position object
        /// </summary>
        /// <param name="x">The X coordinate</param>
        /// <param name="y">The Y coordinate</param>
        public PlanarPosition(double x, double y)
        {
            XCoord = x;
            YCoord = y;
        }

        /// <summary>
        /// Overrides the Planar Position ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var result =
                 "(XCoord: " + XCoord + "," +
                 "YCoord: " + YCoord + ")";
            return result;

        }
    }
}

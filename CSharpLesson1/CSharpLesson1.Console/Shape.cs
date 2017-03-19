using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1.ConsoleApp
{
    public class Shape
    {
        /// <summary>
        /// Name of the shape
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Corner type of the shape
        /// </summary>
        public CornerType CornerType { get; set; }

        /// <summary>
        /// Creates a new instance of a shape
        /// </summary>
        /// <param name="name">The name of the shape</param>
        /// <param name="cornerType">The type of corner of the shape</param>
        public Shape(string name, CornerType cornerType)
        {
            Name = name;
            CornerType = cornerType;
        }
        /// <summary>
        /// Overrides the Shape ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var result =
                "(Name: " + Name + "|" +
                "CornerType: " + CornerType + ")";
            return result;

        }
    }
}

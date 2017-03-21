using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson1.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dot1Position = new PlanarPosition(0, 0);
            var dot1Shape = new Shape("round", CornerType.Rounded);
            var dot1 = new Dot(dot1Shape, dot1Position, 4);

            var dot2 = new Dot()
            {
                Color = "black",
                Shape = new Shape("square", CornerType.Square),
                Position = new PlanarPosition(5, 5),
                Size = 4
            };

            var dot3 = new Dot(null, dot1Position, 8)
            {
                Color = "purple"
            };

            Console.WriteLine(dot1);
            Console.WriteLine(dot2);
            Console.WriteLine(dot3);
            Console.Read();
        }
    }
}

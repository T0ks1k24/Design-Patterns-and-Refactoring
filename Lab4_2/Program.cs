

using Lab4_2.@class;

namespace Lab4_2
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            BirdAdapter adaptedPlane = new BirdAdapter(airplane);

            Console.WriteLine(adaptedPlane.Fly());
            Console.ReadLine();
        }
    }
}

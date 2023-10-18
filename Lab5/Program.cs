namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try { Circle a = new Circle(5); }
            catch (InvalidRadiusException) { Console.WriteLine("Circle a exited with InvalidRadiusException"); }

            try { Circle b = new Circle(-5); }
            catch (InvalidRadiusException) { Console.WriteLine("Circle b exited with InvalidRadiusException"); }


            try { Circle c = new Circle(0); }
            catch (InvalidRadiusException) { Console.WriteLine("Circle c exited with InvalidRadiusException"); }

        }
    }
}
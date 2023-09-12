namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of tires you would like your vehicle to have.");
            int userInput = int.Parse(Console.ReadLine());

            IVehicle vehicle1 = VehicleFactory.GetVehicle(userInput);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is your vehicle!");
            vehicle1.Build();
            Console.WriteLine($"Number of doors: {vehicle1.NumberOfDoors}");
            Console.WriteLine($"Is fast: {vehicle1.IsFast}");
        }
    }
}

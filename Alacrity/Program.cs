// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var cars = new List<Car>{
        new Car{
            Make = "Aston Martin",
            Price = 50000,
            Year = 2012
        },
        new Car{
            Make = "BMW",
            Price = 30000,
            Year = 2014
        },
        new Car{
            Make = "Chevrolet",
            Price = 20000,
            Year = 2013
        },
        new Car{
            Make = "Datsun",
            Price = 2000,
            Year = 2001
        },
};

var averageCarPrice = cars.Select(x => x.Price).Sum() / cars.Count;
var oldestCar = cars.Min(car => car.Year);
var expensivecar = cars.Max(car => car.Price);

Console.WriteLine("List of Cars: ");
foreach (var carItem in cars)
{
    Console.WriteLine($"Make: {carItem.Make} \t Price: {carItem.Price} \t Year: {carItem.Year}");
}

Console.WriteLine("Create new car: ");
Console.WriteLine("Enter the car's make: ");
string make = Console.ReadLine();
Console.WriteLine("Enter the car's price: ");
double price = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the car's year: ");
int year = int.Parse(Console.ReadLine());
// Create new Car object with the  input.
Car car = new Car
{
    Make = make,
    Price = price,
    Year = year
};
cars.Add(car);

Console.WriteLine("List of Cars: ");
foreach (var carItem in cars)
{
    Console.WriteLine($"Make: {carItem.Make} \t Price: {carItem.Price} \t Year: {carItem.Year}");
}
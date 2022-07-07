using Carslab;

List<Car> carList = new List<Car>()
{
    new Car ("Lamborghini", "Huracan", 2022,20000),
    new Car ("Tesla", "S", 2021,100000),
    new Car ("Ford", "Taurus", 2015,15000),
    new UsedCar ("Toyota", "Corolla", 2000,10000, 250000),
    new UsedCar ("Honda", "Civic", 2010,5000, 100000),
    new UsedCar ("Mariocart", "Yoshi", 1983, 10000000, 10000),
};
Console.WriteLine("Welcome to Fun World Lot");
Car.ListCars(carList);
Console.WriteLine("Which car would you like?");
int input = int.Parse(Console.ReadLine());
Console.WriteLine($"{carList[input-1].Make} {carList[input-1].Model} {carList[input-1].Year} {carList[input-1].Price}");
Car.Remove(input, carList);
Console.WriteLine("Fine choice! You will recieve this car in 3 weeks!");
Car.ListCars(carList);
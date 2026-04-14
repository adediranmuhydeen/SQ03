using Week1Project;

var num = 0;

//Greeting(out  num);
if(num == 0)
{
    //Greeting(out num);
}





void Greeting(out int num)
{
    Console.WriteLine("Welcome to my personal manager\nPlease choose any of the following options:\n1. Add a new contact\n2. View contacts\n3. Exit");
    var input = Console.ReadLine();

    var isNumber = int.TryParse(input, out int ourNum);
    if(!isNumber)
    {
        Console.WriteLine("The input entered is not a number, please try again");
    }
    else
    {
        if (ourNum < 1 || ourNum > 3)
        {
            Console.WriteLine("The input entered is not within the expected value range, please try again");
        }
    }
    num = ourNum;
}

List<Car> cars = new List<Car>
{
    new Car { Doors = 4, Name = "Toyota", Model = "Corolla" },
    new Car { Doors = 2, Name = "Honda", Model = "Civic" },
    new Car { Doors = 4, Name = "Ford", Model = "Mustang" },
    new Car { Doors = 2, Name = "Ford", Model = "Edge" },
    new Car { Doors = 4, Name = "Ford", Model = "Explorer" },
    new Car { Doors = 4, Name = "Honda", Model = "Accord" },
    new Car { Doors = 3, Name = "Honda", Model = "Civic" },
    new Car { Doors = 4, Name = "Toyota", Model = "Camry" }
};


var toyotaCars = from c in cars
                 where c.Name == "Toyota"
                    select c;

var toyoCars2 = cars.Where(c => c.Name == "Toyota");

Console.WriteLine(toyotaCars.Count());

var allDcars =from car in cars 
              where car.Name.Contains('d') 
              select car;
var allDcars2 = cars.Where(car => car.Name.Contains('d'));



var groupedCars = from car in cars
                  group car by car.Name;
Console.WriteLine(groupedCars.Count());

Car car2 = new Car();
Console.WriteLine($"Name: {car2.Name}, Model: {car2.Model}, Doors: {car2.Doors}");
var car1 = new Car("Toyota", "Avensis");

var viewModel = new ClassViewModel(car2);

var listOfViewModels = ClassViewModel.ListViewModel(cars);

foreach(var model in listOfViewModels)
{
    Console.WriteLine(model.Name);
    Console.WriteLine(model.Model);
    Console.WriteLine("\n");
}
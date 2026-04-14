namespace Week1Project;

public class Car
{
    public int Id { get; set; }
    public int Doors { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }

    public Car()
    {
        Doors = 0;
        Name = "First Name";
        Model = "First Model";
    }

    public Car( string name, string model)
    {
        Doors = 4;
        Name = name;
        Model = model;
    }
}

public class ClassViewModel
{
    public int Doors { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }

    public ClassViewModel(Car car)
    {
        Doors = car.Doors;
        Name = car.Name;
        Model = car.Model;
    }

    public static List<ClassViewModel> ListViewModel(List<Car> cars)
    {
        return cars.Select(c => new ClassViewModel(c)).ToList();
    }
}

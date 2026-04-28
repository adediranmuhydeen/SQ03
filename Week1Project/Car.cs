using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

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

public class Coupon
{
    public Guid Id { get; set; }
    public string CouponCode { get; set; } = string.Empty;
    public decimal DiscountAmount { get; set; }
    public int MinAmount { get; set; }
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


public class  DelegateExmaple
{
    public delegate int PlayWithNumber(int b, int a);

    public static int Add(int a, int b)
    {
        Console.WriteLine("This is Add method\n");

        return a + b;
    }

    public static  int Subtract(int a, int b)
    {
        Console.WriteLine("This is Subtract method\n");
        return a - b;
    }

    /// <summary>
    /// Method to mutiply two numbers
    /// </summary>
    /// <param name="a" >First number to be multiplied</param>
    /// <param name="b">Second Number to be multiplied</param>
    /// <returns>int which is a product of both a and b</returns>
    public static int Multiply(int a, int b)
    {
        Console.WriteLine("This is Multiply method\n");

        return a * b;
    }
    public static int Divide(int a, int b)
    {
        Console.WriteLine("This is Division method\n");

        return a / b;
    }

    

    // public void Run()
    //{
    //    Console.WriteLine(play(5, 10));
    //    play = Subtract;
    //    Console.WriteLine(play(5, 10));
    //    play = Multiply;
    //    Console.WriteLine(play(5, 10));
    //    play = Divide;
    //    Console.WriteLine(play(5, 10));
    //}

}

public enum Employeeype
{
    FullTime ,
    PartTime,
    Contractor
}

public class  EmployeesService
{
     //string cs = "Server=THE-DELES;Database=EcomerceCoupon;Trusted_Connection=true;";

    public static async Task GetCoupons()
    {
        var cs = "Server=THE-DELES;Database=EcomerceCoupon;Trusted_Connection=True;TrustServerCertificate=True;";
        SqlConnection cnn = new(cs);
        await cnn.OpenAsync();
        var query = $"Select * From Coupons";

        using (SqlCommand cmd = new(query, cnn))
        {
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("data has been read");
        }
    }

}
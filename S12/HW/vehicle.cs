using static System.Math;

public interface Ivehicle
{
    public void printInfo();
    public double Distance(int Fuel);
    public bool CanFitInAMediumGaradge();
}
public class Bike: Ivehicle
{
    private int MaxSpeed;
    private int BuiltYear;
    private string Model;
    private int MaxFuel;
    public Bike(int MaxSpeed,int BuiltYear,string Model,int MaxFuel)
    {
        this.MaxSpeed = MaxSpeed;this.BuiltYear = BuiltYear;this.Model = Model;
        this.MaxFuel = MaxFuel;
    }
    public void printInfo()
    {
        System.Console.WriteLine($"This is a bike of Model {this.Model}.It was built in {this.BuiltYear} and it can go as fast as {this.MaxSpeed}km/h. {this.MaxFuel}L");
    }
    public double Distance(int Fuel)
    {
        System.Console.Write($"The Fuel Consumption of this bike is 4L/km. So with {Fuel}L of Gasoline: ");
        return Math.Round((double)MaxFuel*100/4,2);
    }
    public double max_distanceInT(double time)
    {
        return time*MaxSpeed;
    }
    public bool CanFitInAMediumGaradge(){
        return true;
    }

}

public class Car
{
    private string Model;
    private int MaxFuel;
    private int Cappacity;
    public Car(string Model,int MaxFuel,int Cappacity)
    {
        this.Model = Model;this.MaxFuel = MaxFuel;this.Cappacity = Cappacity;
    }
    public void printInfo()
    {
        System.Console.WriteLine($"This car is a {this.Model}. {this.Cappacity} can fit inside this car. The maximum amount of fuel is {this.MaxFuel}");
    }
    public double Distance(int Fuel)
    {
        System.Console.Write($"The Fuel Consumption of this car is 7.5L/km. So with {Fuel}L of Gasoline: ");
        return Math.Round((double)MaxFuel*100/7.5,2);
    }
    public bool CanFitInAMediumGaradge()
    {
        return true;
    }
}

public class Truck
{
    private int TireNum;
    private bool above6Ton;
    private int price;
    private int MaxFuel;

    public Truck(int TireNum,bool above6Ton,int Price,int MaxFuel)
    {
        this.TireNum = TireNum;this.above6Ton=above6Ton;this.price=Price;
        this.MaxFuel=MaxFuel;
    }
    public void printInfo()
    {
        string s;
        if(above6Ton){
            s = "is";
        }else{
            s = "is not";
        }
        System.Console.WriteLine($"This truck has {this.TireNum} tires. It {s} 6Tons. Its price is {this.price}$.{this.MaxFuel}L.");
        }
        public double Distance(int Fuel)
        {
        System.Console.Write($"The Fuel Consumption of this truck is 32.5L/km. So with {Fuel}L of Gasoline: ");
        return Math.Round((double)MaxFuel*100/32.5,2);
        }
        public bool CanFitInAMediumGaradge()
        {
            return false;
        }
    
}
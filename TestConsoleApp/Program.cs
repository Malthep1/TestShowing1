using System;
//Author: Malthe
namespace TestConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person Malthe = new Person("Malthe Petersen");
            Console.WriteLine(Malthe.getName());
            Console.WriteLine(Malthe.hasCar());
            Malthe.setCar("Ford Fiesta");
            Console.WriteLine(Malthe.hasCar());
            Console.WriteLine(Malthe.getCar().getCarModelName());
        }
    }

class Person
{
    private String name;
    private Car car;
    public Person(String name)
    {
        this.name = name;
    }
    public String getName() 
    {
        return name;
    }

    public void setCar(String carModelName)
    {
        this.car = new Car(carModelName);
    }

    public Car getCar()
    {
        return car;
    }

    public Boolean hasCar()
    {
        if (car != null)
        {
            return true;
        }
        return false;
    }
}

class Car
{
    private String carModelName;

    public Car(String carModelName)
    {
        this.carModelName = carModelName;
    }

    public void setCarModelName(String carModelName)
    {
        this.carModelName = carModelName;
    }

    public String getCarModelName()
    {
        return carModelName;
    }
    
}

}
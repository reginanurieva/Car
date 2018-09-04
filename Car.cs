using System;
using System.Collections.Generic;

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;

  public Car(string carModel, int carPrice = 50000, int carMiles = 1000)
  {
    MakeModel = carModel;
    Price = carPrice;
    Miles = carMiles;
  }

  public string getModel()
  {
    return MakeModel;
  }

  public int getPrice()
  {
    return Price;
  }

  public int getMiles()
  {
    return Miles;
  }

  public void setModel(string carModel)
  {
    if (carModel != "")
    {
      MakeModel = carModel;
    }
    else
    {
      Console.WriteLine("Enter a valid name.");
    }
  }

  public void setPrice(int carPrice)
  {
    if (carPrice > 0)
    {
      Price = carPrice;
    }
    else
    {
      Console.WriteLine("Enter a number more than 0");
    }
  }

  public void setMiles(int carMiles)
  {
    if (carMiles > 0)
    {
      Miles = carMiles;
    }
    else
    {
      Console.WriteLine("Enter a number more than 0");
    }
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911");
    Car ford = new Car("2011 Ford F450");
    Car lexus = new Car("2013 Lexus RX 350");
    Car mercedes = new Car("Mercedes Benz CLS550", 39900,37979);

    List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes};

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.getPrice() < maxPrice && automobile.getMiles() < maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.getModel());
    }
  }
}

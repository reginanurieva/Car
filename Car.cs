using System;
using System.Collections.Generic;

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;
  private string Message;

//new Car("benz", "message")
  public Car(string carModel, string carMessage)
  {
    MakeModel = carModel;
    Price = 50000;
    Miles = 1000;
    Message = carMessage;
  }

//new Car("benz")
//new Car("benz", 34000);
//new Car("benz", 55000, 2000);
//new Car("benz", 666000, 2000, "message");

//new Car("benz", "message") => Not working
  public Car(string carModel, int carPrice = 50000, int carMiles = 1000, string carMessage = "default message")
  {
    MakeModel = carModel;
    Price = carPrice;
    Miles = carMiles;
    Message = carMessage;
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

  public string getMessage()
  {
    return Message;
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

  public void setMessage(string carMessage)
  {
    if(carMessage != "")
    {
      Message = carMessage;
    }
    else
    {
      Console.WriteLine("Enter valid message!");
    }
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", "Expensive car");
    Car ford = new Car("2011 Ford F450", "American brand");
    Car lexus = new Car("2013 Lexus RX 350", "Another expensive car");
    Car mercedes = new Car("Mercedes Benz CLS550", 39900,37979, "German brand");

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
    if(CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("No result");
    }
    else
    {
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.getModel());
        Console.WriteLine(automobile.getMessage());
      }
    }
    Console.WriteLine("Write Message");
    string message = Console.ReadLine();
    porsche.setMessage(message);
    Console.WriteLine(porsche.getMessage());
  }
}

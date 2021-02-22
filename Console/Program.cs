using System;
using Businiess.Concrate;
using DataAccesss.Concrate.InMemory;

namespace ConsoleUI
{
    class Program
    {
      

        static void Main(string[] args)
        {

            CarManeger carManeger = new CarManeger(new InMemoryCarDal() );

            foreach (var car in carManeger.GetAll())
            {
                Console.WriteLine(car.CarName);
               
            }
        
        }
    }
}

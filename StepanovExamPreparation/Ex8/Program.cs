﻿using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args) 
        {
            Car car = new Car("Volkswagen");
            car.TypeCar = new DieselCar();
            car.TypeCar.Move();
        }
    }
}
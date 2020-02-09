using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CarBuilder :ICarBuilder
    {
        private Car car = new Car();

        public void SetBrand()
        {
            car.Brand = "BMW";
        }
        public void SetColor()
        {
            car.Color = "red";
        }
        public void SetYearOfProduction()
        {
            car.ProductionYear = DateTime.Now;
        }
        public void SetType()
        {
            car.Type = "Convertible";
        }

        public Car ReturnProducedCar()
        {
            return car;
        }
    }
}

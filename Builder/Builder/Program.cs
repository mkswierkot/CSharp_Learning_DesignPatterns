using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director boss = new Director();

            ICarBuilder worker = new CarBuilder();

            boss.ProduceMeACar(worker);

            Car producedCar = worker.ReturnProducedCar();
            producedCar.PresentCar();
        }
    }
}

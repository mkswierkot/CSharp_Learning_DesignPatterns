using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ICarBuilder
    {
        void SetBrand();
        void SetColor();
        void SetYearOfProduction();
        void SetType();
        Car ReturnProducedCar();
    }
}

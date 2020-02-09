using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
   public class Director
    {
        public void ProduceMeACar(ICarBuilder carBuilder)
        {
            carBuilder.SetBrand();
            carBuilder.SetColor();
            carBuilder.SetType();
            carBuilder.SetYearOfProduction();
        }
    }
}

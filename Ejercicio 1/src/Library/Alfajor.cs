using System;

namespace Expert_SRP
{
//cumple con el expert porque es la clase que tiene la informacion necesaria para poder cumpli responsabilidad que se le asigno
//La clase alfajor cumple con el principio srp porque la unica responsabilidad que tiene es conocer el precio de sus ingredientes
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}
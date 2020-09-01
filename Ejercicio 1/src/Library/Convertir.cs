using System;

namespace Convertir_SRP
{
    public class Convertir
    {
//Le saque la responsabilidad de hacer la conversión a la clase kiosco para que no tenga más de un motivo para cambiar que la responsabilidad de la clase sea saber si se puede comparar el producto o no
private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}
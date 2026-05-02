using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Tras un trimestre agotador en la oficina, decides descansar y tomarte unas vacaciones. Así que reservas un vuelo para ti y tu novia e intentas dejar atrás todo el lío.
Necesitarás alquilar un coche para desplazarte durante tus vacaciones. El encargado de la empresa de alquiler te hará buenas ofertas.
El alquiler del coche cuesta 40 dólares por día. Si lo alquilas durante 7 días o más, obtienes un descuento de 50 dólares. Si lo alquilas durante 3 días o más, obtienes un descuento de 20 dólares.
Escribe un código que muestre el monto total para diferentes días (d).
*/

namespace CSharp
{
    public class Transportation_On_Vacation
    {
        public int Days {get; set; }

        public Transportation_On_Vacation(int days)
        {
            Days = days;
        }

        public int RentalCarCost()
        {
            int dailyRate = 40;
            int total = Days * dailyRate;

            if (Days >= 7)
            {
                total -= 50;
            }
            else if (Days >= 3)
            {
                total -= 20;
            }

            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transportation_On_Vacation viaje = new Transportation_On_Vacation(7);
            Console.WriteLine($"Costo: {viaje.RentalCarCost()}");
        }
    }
}


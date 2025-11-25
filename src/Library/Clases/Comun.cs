using System;

namespace Library.Clases
{
    public class Comun : Conductor
    {

      
        public Comun(string cedula, string nombre, string apellido, string vehiculo, string calificacion, string biografia) 
            : base(cedula, nombre, apellido, vehiculo, calificacion, biografia)
        {
           //Al usar herencia, no tendriamos que repetir codigo que ya tenemos. Esta es una de las bendiciones de Herencia. Esto hace que tengamos menos errores de tipeo y no hacemos tareas reptidas.
        }


        public override void LLevarPasajero(Pasajero pasajero)
        {
            if (this.Pasajero == null)
            {
                this.Pasajero = pasajero;
                Console.WriteLine($"{Nombre} {Apellido} subió. Estamos llenitos ");
            }
            else
            {
                Console.WriteLine($"{Nombre} {Apellido} disculpa pero tamo completo");
            }
        }

       
    }
}
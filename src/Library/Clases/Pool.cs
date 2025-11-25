using System;
using System.Collections.Generic;

namespace Library.Clases
{
    public class Pool : Conductor
    {
        private List<Pasajero> pasajerosPool = new List<Pasajero>();
        public int CapacidadMaxima { get; set; }

        public Pool(string cedula, string nombre, string apellido, string vehiculo, string calificacion, string biografia, int capacidadmax) : base(cedula, nombre, apellido, vehiculo, calificacion, biografia) // se llama al constructor de la clase padre, estamos heredando.
                {
                    this.CapacidadMaxima = capacidadmax;
                }
        
        public override void LLevarPasajero(Pasajero pasajero)
        {
            if (pasajerosPool.Count < CapacidadMaxima)
            {
                pasajerosPool.Add(pasajero);
                Console.WriteLine($"{Nombre} {Apellido} dale, que hay espacio. Quedan {CapacidadMaxima - pasajerosPool.Count} lugares todavía.");
            }
            else
            {
                Console.WriteLine($"{Nombre} {Apellido}: pa', estamos llenos estimado. ");
            }
        }


        
    }
}
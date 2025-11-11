namespace Library.Clases
{
    public class Pool : Conductor
    {
        public int CapacidadMaxima { get; set; }

        public Pool(string cedula, string nombre, string apellido, string vehiculo, string calificacion, string biografia) : base(cedula, nombre, apellido, vehiculo, calificacion, biografia)
                {
                    this.Cedula = cedula;
                    this.Nombre = nombre;
                    this.Apellido = apellido;
                    this.Vehiculo = vehiculo;
                    this.Calificacion = calificacion;
                    this.Biografia = biografia;
                    //Ver si poner capacidad maxima.
                }
        
        public override void LLevarPasajero()
        {
            // logica, aca solo lleva el pasajero y puede llevar uno. 
        }

        
    }
}
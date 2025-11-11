namespace Library.Clases
{
    public class Conductor
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Vehiculo { get; set; }
        public string Calificacion { get; set; }
        public string Biografia { get; set; }
        
        public Pasajero Pasajero { get; set; }
        
        

        public Conductor(string cedula, string nombre, string apellido, string vehiculo, string calificacion,
            string biografia)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Vehiculo = vehiculo;
            this.Calificacion = calificacion;
            this.Biografia = biografia;
        }
        
        public virtual void LLevarPasajero()
        {
            throw new System.NotImplementedException();
        }
    }
}
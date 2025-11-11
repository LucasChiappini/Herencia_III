namespace Library.Clases
{
    public class Pasajero
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calificacion { get; set; }

        public Pasajero(string cedula, string nombre, string apellido, string calificacion)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Calificacion = calificacion;
        }
        
    }
}
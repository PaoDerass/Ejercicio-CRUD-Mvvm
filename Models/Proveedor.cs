using SQLite;

namespace EjercicioCRUDMvvm.Models
{
    public class Proveedor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
    }
}

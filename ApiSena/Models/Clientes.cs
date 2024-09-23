namespace ApiSena.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public int Nit { get; set; }
        public required string Razonsocial { get; set; }
        public required string Celular { get; set; }
        public required string Correo { get; set; }
        public required string Direccion { get; set; }
        public required string Ciudad { get; set; }
    }
}

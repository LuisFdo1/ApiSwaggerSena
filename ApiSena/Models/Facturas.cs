namespace ApiSena.Models
{
    public class Facturas
    {
        public int Id { get; set; }
        public int NroFactura { get; set; }
        public int NitCliente { get; set; }
        public required string RazonSocial { get; set; }
        public required string Celular { get; set; }
        public required string Correo { get; set; }
        public required string Direccion { get; set; }
        public required string Ciudad { get; set; }
        public required string Vendedor { get; set; }
        public int IdItem { get; set; }
        public required string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public required decimal ValorUnit { get; set; }  
        public required decimal SubTotal { get; set; }  
        public required decimal TotalFactura { get; set; }       
    }
}

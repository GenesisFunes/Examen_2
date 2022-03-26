using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string NombreCliente { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaPedido { get; set; }


        public Pedido()
        {
        }

        public Pedido(int idPedido, string nombreCliente, string descripcion, int cantidad, decimal precioUnitario, decimal total, DateTime fechaPedido)
        {
            IdPedido = idPedido;
            NombreCliente = nombreCliente;
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Total = total;
            FechaPedido = fechaPedido;
        }
    }
}

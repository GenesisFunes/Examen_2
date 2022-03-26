using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2Parcial
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        PedidoDA pedidoDA = new PedidoDA();

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }


        private void ListarPedidos()
        {
            DetallePedidoDataGridView.DataSource = pedidoDA.ListarPedidos();
        }

        private void GuardarPedidoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                pedido.NombreCliente = NombreClienteTextBox.Text;
                pedido.Descripcion = DescripcionPedidoTextBox.Text;
                pedido.Cantidad = Convert.ToInt32(CantidadPedidoTextBox.Text);
                pedido.PrecioUnitario = Convert.ToDecimal(PrecioUnitarioPedidoTextBox.Text);
                pedido.Total = Convert.ToDecimal(TotalPagarTextBox.Text);
                pedido.FechaPedido = FechaDateTimePicker.Value;
            }
            catch (Exception ex)
            {
            }
            
            
        }
    }
}

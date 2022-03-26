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

        Pedido pedido = new Pedido();
        PedidoDA pedidoDA = new PedidoDA();

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }


        private void ListarPedidos()
        {
            DetallePedidoDataGridView.DataSource = pedidoDA.ListarPedidos();
        }
    }
}

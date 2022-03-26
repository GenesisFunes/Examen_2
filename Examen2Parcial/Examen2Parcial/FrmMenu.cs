using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2Parcial
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        FrmProducto frmProducto = null;
        FrmPedido frmPedido = null;

        private void toolStripEx2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
            {
                frmProducto.Activate();
            }
        }

        private void ListaPedidosToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmPedido == null)
            {
                frmPedido = new FrmPedido();
                frmPedido.MdiParent = this;
                frmPedido.Show();
            }
            else
            {
                frmPedido.Activate();
            }
        }
    }
}

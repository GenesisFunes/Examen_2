namespace Examen2Parcial
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionPedidoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadPedidoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecioUnitarioPedidoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPagarTextBox = new System.Windows.Forms.TextBox();
            this.DetallePedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePedidoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.TotalPagarTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PrecioUnitarioPedidoTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CantidadPedidoTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DescripcionPedidoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NombreClienteTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(764, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // DescripcionPedidoTextBox
            // 
            this.DescripcionPedidoTextBox.Location = new System.Drawing.Point(531, 40);
            this.DescripcionPedidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionPedidoTextBox.Name = "DescripcionPedidoTextBox";
            this.DescripcionPedidoTextBox.Size = new System.Drawing.Size(225, 22);
            this.DescripcionPedidoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(143, 43);
            this.NombreClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(225, 22);
            this.NombreClienteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre cliente:";
            // 
            // CantidadPedidoTextBox
            // 
            this.CantidadPedidoTextBox.Location = new System.Drawing.Point(531, 77);
            this.CantidadPedidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadPedidoTextBox.Name = "CantidadPedidoTextBox";
            this.CantidadPedidoTextBox.Size = new System.Drawing.Size(225, 22);
            this.CantidadPedidoTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha pedido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio unitario:";
            // 
            // PrecioUnitarioPedidoTextBox
            // 
            this.PrecioUnitarioPedidoTextBox.Location = new System.Drawing.Point(531, 112);
            this.PrecioUnitarioPedidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioUnitarioPedidoTextBox.Name = "PrecioUnitarioPedidoTextBox";
            this.PrecioUnitarioPedidoTextBox.Size = new System.Drawing.Size(225, 22);
            this.PrecioUnitarioPedidoTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total a pagar:";
            // 
            // TotalPagarTextBox
            // 
            this.TotalPagarTextBox.Location = new System.Drawing.Point(531, 146);
            this.TotalPagarTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalPagarTextBox.Name = "TotalPagarTextBox";
            this.TotalPagarTextBox.Size = new System.Drawing.Size(225, 22);
            this.TotalPagarTextBox.TabIndex = 10;
            // 
            // DetallePedidoDataGridView
            // 
            this.DetallePedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallePedidoDataGridView.Location = new System.Drawing.Point(0, 222);
            this.DetallePedidoDataGridView.Name = "DetallePedidoDataGridView";
            this.DetallePedidoDataGridView.Size = new System.Drawing.Size(795, 135);
            this.DetallePedidoDataGridView.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(795, 357);
            this.Controls.Add(this.DetallePedidoDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePedidoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionPedidoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TotalPagarTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrecioUnitarioPedidoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CantidadPedidoTextBox;
        private System.Windows.Forms.DataGridView DetallePedidoDataGridView;
    }
}
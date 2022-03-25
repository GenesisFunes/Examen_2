namespace Examen2Parcial
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioTextBox.Location = new System.Drawing.Point(88, 32);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(268, 22);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave:";
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClaveTextBox.Location = new System.Drawing.Point(88, 72);
            this.ClaveTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(268, 22);
            this.ClaveTextBox.TabIndex = 3;
            // 
            // AceptarButton
            // 
            this.AceptarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AceptarButton.Location = new System.Drawing.Point(66, 129);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(112, 28);
            this.AceptarButton.TabIndex = 4;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = false;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelarButton.Location = new System.Drawing.Point(279, 129);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(112, 28);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(414, 192);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}


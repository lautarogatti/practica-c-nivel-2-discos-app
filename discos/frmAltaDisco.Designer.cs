namespace discos
{
    partial class frmAltaDisco
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
            this.txbCantCan = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbFechaLanz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.pbxImgAlta = new System.Windows.Forms.PictureBox();
            this.txbUrlImg = new System.Windows.Forms.TextBox();
            this.lblUrlImg = new System.Windows.Forms.Label();
            this.btnAjuntarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCantCan
            // 
            this.txbCantCan.Location = new System.Drawing.Point(95, 112);
            this.txbCantCan.Name = "txbCantCan";
            this.txbCantCan.Size = new System.Drawing.Size(100, 20);
            this.txbCantCan.TabIndex = 2;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(95, 15);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 0;
            // 
            // txbFechaLanz
            // 
            this.txbFechaLanz.Location = new System.Drawing.Point(95, 62);
            this.txbFechaLanz.Name = "txbFechaLanz";
            this.txbFechaLanz.Size = new System.Drawing.Size(100, 20);
            this.txbFechaLanz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha \r\nde \r\nLanzamiento (*)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad\r\nde \r\nCanciones (*)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(107, 298);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(353, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(29, 209);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(45, 13);
            this.lblEstilo.TabIndex = 12;
            this.lblEstilo.Text = "Estilo (*)";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(22, 240);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(55, 39);
            this.lblEdicion.TabIndex = 13;
            this.lblEdicion.Text = "Tipo\r\nde\r\nEdicion (*)\r\n";
            this.lblEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(95, 206);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(100, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(95, 253);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(100, 21);
            this.cboEdicion.TabIndex = 5;
            // 
            // pbxImgAlta
            // 
            this.pbxImgAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImgAlta.Location = new System.Drawing.Point(259, 12);
            this.pbxImgAlta.Name = "pbxImgAlta";
            this.pbxImgAlta.Size = new System.Drawing.Size(269, 267);
            this.pbxImgAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgAlta.TabIndex = 4;
            this.pbxImgAlta.TabStop = false;
            // 
            // txbUrlImg
            // 
            this.txbUrlImg.Location = new System.Drawing.Point(95, 159);
            this.txbUrlImg.Name = "txbUrlImg";
            this.txbUrlImg.Size = new System.Drawing.Size(100, 20);
            this.txbUrlImg.TabIndex = 3;
            this.txbUrlImg.Leave += new System.EventHandler(this.txbUrlImg_Leave);
            // 
            // lblUrlImg
            // 
            this.lblUrlImg.AutoSize = true;
            this.lblUrlImg.Location = new System.Drawing.Point(23, 149);
            this.lblUrlImg.Name = "lblUrlImg";
            this.lblUrlImg.Size = new System.Drawing.Size(42, 39);
            this.lblUrlImg.TabIndex = 11;
            this.lblUrlImg.Text = "Url\r\nImagen\r\nTapa";
            this.lblUrlImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjuntarImg
            // 
            this.btnAjuntarImg.Location = new System.Drawing.Point(205, 158);
            this.btnAjuntarImg.Name = "btnAjuntarImg";
            this.btnAjuntarImg.Size = new System.Drawing.Size(19, 23);
            this.btnAjuntarImg.TabIndex = 14;
            this.btnAjuntarImg.Text = "+";
            this.btnAjuntarImg.UseVisualStyleBackColor = true;
            this.btnAjuntarImg.Click += new System.EventHandler(this.btnAjuntarImg_Click);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 334);
            this.Controls.Add(this.btnAjuntarImg);
            this.Controls.Add(this.pbxImgAlta);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblUrlImg);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFechaLanz);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbUrlImg);
            this.Controls.Add(this.txbCantCan);
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCantCan;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbFechaLanz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.PictureBox pbxImgAlta;
        private System.Windows.Forms.TextBox txbUrlImg;
        private System.Windows.Forms.Label lblUrlImg;
        private System.Windows.Forms.Button btnAjuntarImg;
    }
}
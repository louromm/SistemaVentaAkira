namespace SistemaVentaAkira.View.Reporte_Venta
{
    partial class Reporte_ventaAnual
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
            System.Windows.Forms.Label lblSeleccionePeriodoAnual;
            this.panel_contenido = new System.Windows.Forms.Panel();
            this.dtp_periodoDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.LblPeriodoDesde = new System.Windows.Forms.Label();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            lblSeleccionePeriodoAnual = new System.Windows.Forms.Label();
            this.panel_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionePeriodoAnual
            // 
            lblSeleccionePeriodoAnual.AutoSize = true;
            lblSeleccionePeriodoAnual.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblSeleccionePeriodoAnual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblSeleccionePeriodoAnual.Location = new System.Drawing.Point(105, 28);
            lblSeleccionePeriodoAnual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSeleccionePeriodoAnual.Name = "lblSeleccionePeriodoAnual";
            lblSeleccionePeriodoAnual.Size = new System.Drawing.Size(263, 23);
            lblSeleccionePeriodoAnual.TabIndex = 34;
            lblSeleccionePeriodoAnual.Text = "Seleccione Período Anual";
            lblSeleccionePeriodoAnual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_contenido
            // 
            this.panel_contenido.Controls.Add(this.dtp_periodoDesde);
            this.panel_contenido.Controls.Add(this.btnFiltrar);
            this.panel_contenido.Controls.Add(this.LblPeriodoDesde);
            this.panel_contenido.Controls.Add(lblSeleccionePeriodoAnual);
            this.panel_contenido.Controls.Add(this.IcClose);
            this.panel_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenido.Location = new System.Drawing.Point(0, 0);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(481, 296);
            this.panel_contenido.TabIndex = 0;
            // 
            // dtp_periodoDesde
            // 
            this.dtp_periodoDesde.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_periodoDesde.Location = new System.Drawing.Point(269, 117);
            this.dtp_periodoDesde.Name = "dtp_periodoDesde";
            this.dtp_periodoDesde.Size = new System.Drawing.Size(99, 26);
            this.dtp_periodoDesde.TabIndex = 45;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(189, 203);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(93, 28);
            this.btnFiltrar.TabIndex = 44;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // LblPeriodoDesde
            // 
            this.LblPeriodoDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblPeriodoDesde.AutoSize = true;
            this.LblPeriodoDesde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeriodoDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblPeriodoDesde.Location = new System.Drawing.Point(88, 122);
            this.LblPeriodoDesde.Name = "LblPeriodoDesde";
            this.LblPeriodoDesde.Size = new System.Drawing.Size(124, 21);
            this.LblPeriodoDesde.TabIndex = 43;
            this.LblPeriodoDesde.Text = "Período desde:";
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(24, 28);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 33;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // Reporte_ventaAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 296);
            this.Controls.Add(this.panel_contenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_ventaAnual";
            this.Text = "Seleccion período anual";
            this.panel_contenido.ResumeLayout(false);
            this.panel_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenido;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.DateTimePicker dtp_periodoDesde;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label LblPeriodoDesde;
    }
}
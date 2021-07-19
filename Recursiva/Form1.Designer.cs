
namespace Recursiva
{
    partial class Form1
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
            this.gbPunto1 = new System.Windows.Forms.GroupBox();
            this.txtPersonasRegistradas = new System.Windows.Forms.TextBox();
            this.lblPunto1 = new System.Windows.Forms.Label();
            this.gbPunto2 = new System.Windows.Forms.GroupBox();
            this.txtSociosRacing = new System.Windows.Forms.TextBox();
            this.lblPunto2 = new System.Windows.Forms.Label();
            this.btnPunto3 = new System.Windows.Forms.Button();
            this.btnPunto4 = new System.Windows.Forms.Button();
            this.btnPunto5 = new System.Windows.Forms.Button();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btbObtenerDatos = new System.Windows.Forms.Button();
            this.lblConsigna = new System.Windows.Forms.Label();
            this.gbPunto1.SuspendLayout();
            this.gbPunto2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPunto1
            // 
            this.gbPunto1.Controls.Add(this.txtPersonasRegistradas);
            this.gbPunto1.Controls.Add(this.lblPunto1);
            this.gbPunto1.Location = new System.Drawing.Point(68, 138);
            this.gbPunto1.Name = "gbPunto1";
            this.gbPunto1.Size = new System.Drawing.Size(379, 78);
            this.gbPunto1.TabIndex = 0;
            this.gbPunto1.TabStop = false;
            this.gbPunto1.Text = "Punto 1";
            // 
            // txtPersonasRegistradas
            // 
            this.txtPersonasRegistradas.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonasRegistradas.Location = new System.Drawing.Point(270, 28);
            this.txtPersonasRegistradas.Name = "txtPersonasRegistradas";
            this.txtPersonasRegistradas.Size = new System.Drawing.Size(101, 27);
            this.txtPersonasRegistradas.TabIndex = 1;
            this.txtPersonasRegistradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPunto1
            // 
            this.lblPunto1.AutoSize = true;
            this.lblPunto1.Location = new System.Drawing.Point(6, 33);
            this.lblPunto1.Name = "lblPunto1";
            this.lblPunto1.Size = new System.Drawing.Size(152, 17);
            this.lblPunto1.TabIndex = 1;
            this.lblPunto1.Text = "Personas Registradas:";
            // 
            // gbPunto2
            // 
            this.gbPunto2.Controls.Add(this.txtSociosRacing);
            this.gbPunto2.Controls.Add(this.lblPunto2);
            this.gbPunto2.Location = new System.Drawing.Point(68, 222);
            this.gbPunto2.Name = "gbPunto2";
            this.gbPunto2.Size = new System.Drawing.Size(379, 78);
            this.gbPunto2.TabIndex = 2;
            this.gbPunto2.TabStop = false;
            this.gbPunto2.Text = "Punto 2";
            // 
            // txtSociosRacing
            // 
            this.txtSociosRacing.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSociosRacing.Location = new System.Drawing.Point(270, 30);
            this.txtSociosRacing.Name = "txtSociosRacing";
            this.txtSociosRacing.Size = new System.Drawing.Size(101, 27);
            this.txtSociosRacing.TabIndex = 1;
            this.txtSociosRacing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPunto2
            // 
            this.lblPunto2.AutoSize = true;
            this.lblPunto2.Location = new System.Drawing.Point(6, 33);
            this.lblPunto2.Name = "lblPunto2";
            this.lblPunto2.Size = new System.Drawing.Size(252, 17);
            this.lblPunto2.TabIndex = 1;
            this.lblPunto2.Text = "Promedio de Edad Hinchas de Racing:";
            this.lblPunto2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPunto3
            // 
            this.btnPunto3.Location = new System.Drawing.Point(68, 306);
            this.btnPunto3.Name = "btnPunto3";
            this.btnPunto3.Size = new System.Drawing.Size(379, 41);
            this.btnPunto3.TabIndex = 3;
            this.btnPunto3.Text = "Punto 3";
            this.btnPunto3.UseVisualStyleBackColor = true;
            this.btnPunto3.Click += new System.EventHandler(this.btnPunto3_Click);
            // 
            // btnPunto4
            // 
            this.btnPunto4.Location = new System.Drawing.Point(68, 353);
            this.btnPunto4.Name = "btnPunto4";
            this.btnPunto4.Size = new System.Drawing.Size(379, 41);
            this.btnPunto4.TabIndex = 4;
            this.btnPunto4.Text = "Punto 4";
            this.btnPunto4.UseVisualStyleBackColor = true;
            this.btnPunto4.Click += new System.EventHandler(this.btnPunto4_Click);
            // 
            // btnPunto5
            // 
            this.btnPunto5.Location = new System.Drawing.Point(68, 400);
            this.btnPunto5.Name = "btnPunto5";
            this.btnPunto5.Size = new System.Drawing.Size(379, 41);
            this.btnPunto5.TabIndex = 5;
            this.btnPunto5.Text = "Punto 5";
            this.btnPunto5.UseVisualStyleBackColor = true;
            this.btnPunto5.Click += new System.EventHandler(this.btnPunto5_Click);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(468, 75);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(790, 381);
            this.dgvRegistros.TabIndex = 8;
            // 
            // btbObtenerDatos
            // 
            this.btbObtenerDatos.Location = new System.Drawing.Point(68, 91);
            this.btbObtenerDatos.Name = "btbObtenerDatos";
            this.btbObtenerDatos.Size = new System.Drawing.Size(379, 41);
            this.btbObtenerDatos.TabIndex = 10;
            this.btbObtenerDatos.Text = "Obtener Datos ";
            this.btbObtenerDatos.UseVisualStyleBackColor = true;
            this.btbObtenerDatos.Click += new System.EventHandler(this.btbObtenerDatos_Click);
            // 
            // lblConsigna
            // 
            this.lblConsigna.AutoSize = true;
            this.lblConsigna.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsigna.Location = new System.Drawing.Point(464, 38);
            this.lblConsigna.Name = "lblConsigna";
            this.lblConsigna.Size = new System.Drawing.Size(0, 24);
            this.lblConsigna.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 535);
            this.Controls.Add(this.lblConsigna);
            this.Controls.Add(this.btbObtenerDatos);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnPunto5);
            this.Controls.Add(this.btnPunto4);
            this.Controls.Add(this.btnPunto3);
            this.Controls.Add(this.gbPunto2);
            this.Controls.Add(this.gbPunto1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursiva Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPunto1.ResumeLayout(false);
            this.gbPunto1.PerformLayout();
            this.gbPunto2.ResumeLayout(false);
            this.gbPunto2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPunto1;
        private System.Windows.Forms.TextBox txtPersonasRegistradas;
        private System.Windows.Forms.Label lblPunto1;
        private System.Windows.Forms.GroupBox gbPunto2;
        private System.Windows.Forms.TextBox txtSociosRacing;
        private System.Windows.Forms.Label lblPunto2;
        private System.Windows.Forms.Button btnPunto3;
        private System.Windows.Forms.Button btnPunto4;
        private System.Windows.Forms.Button btnPunto5;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btbObtenerDatos;
        private System.Windows.Forms.Label lblConsigna;
    }
}


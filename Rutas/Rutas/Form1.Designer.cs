namespace Rutas
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
            this.txtNombreBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarFinal = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminaralultimo = new System.Windows.Forms.Button();
            this.btnEliminarprimero = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeinicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreBase
            // 
            this.txtNombreBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombreBase.Location = new System.Drawing.Point(150, 69);
            this.txtNombreBase.Name = "txtNombreBase";
            this.txtNombreBase.Size = new System.Drawing.Size(195, 29);
            this.txtNombreBase.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nombre Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Hora Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "Hora Inicio";
            // 
            // btnAgregarFinal
            // 
            this.btnAgregarFinal.Location = new System.Drawing.Point(359, 14);
            this.btnAgregarFinal.Name = "btnAgregarFinal";
            this.btnAgregarFinal.Size = new System.Drawing.Size(134, 40);
            this.btnAgregarFinal.TabIndex = 73;
            this.btnAgregarFinal.Text = "Agregar Final";
            this.btnAgregarFinal.UseVisualStyleBackColor = true;
            this.btnAgregarFinal.Click += new System.EventHandler(this.btnAgregarFinal_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(400, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 49);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminaralultimo
            // 
            this.btnEliminaralultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEliminaralultimo.Location = new System.Drawing.Point(514, 18);
            this.btnEliminaralultimo.Name = "btnEliminaralultimo";
            this.btnEliminaralultimo.Size = new System.Drawing.Size(150, 57);
            this.btnEliminaralultimo.TabIndex = 86;
            this.btnEliminaralultimo.Text = "Eliminar Alultimo";
            this.btnEliminaralultimo.UseVisualStyleBackColor = true;
            this.btnEliminaralultimo.Click += new System.EventHandler(this.btnEliminaralultimo_Click);
            // 
            // btnEliminarprimero
            // 
            this.btnEliminarprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEliminarprimero.Location = new System.Drawing.Point(514, 91);
            this.btnEliminarprimero.Name = "btnEliminarprimero";
            this.btnEliminarprimero.Size = new System.Drawing.Size(150, 57);
            this.btnEliminarprimero.TabIndex = 85;
            this.btnEliminarprimero.Text = "Eliminar Primero";
            this.btnEliminarprimero.UseVisualStyleBackColor = true;
            this.btnEliminarprimero.Click += new System.EventHandler(this.btnEliminarprimero_Click);
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLista.Location = new System.Drawing.Point(404, 138);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(88, 37);
            this.btnLista.TabIndex = 84;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEliminar.Location = new System.Drawing.Point(405, 199);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 37);
            this.btnEliminar.TabIndex = 83;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtList
            // 
            this.txtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtList.Location = new System.Drawing.Point(12, 300);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtList.Size = new System.Drawing.Size(684, 151);
            this.txtList.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(15, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 88;
            this.label2.Text = "Nombre Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(202, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 89;
            this.label5.Text = "Hora Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(355, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 90;
            this.label6.Text = "Hora Fin";
            // 
            // dateTimeinicio
            // 
            this.dateTimeinicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeinicio.Location = new System.Drawing.Point(150, 109);
            this.dateTimeinicio.Name = "dateTimeinicio";
            this.dateTimeinicio.ShowUpDown = true;
            this.dateTimeinicio.Size = new System.Drawing.Size(195, 29);
            this.dateTimeinicio.TabIndex = 91;
            this.dateTimeinicio.Value = new System.DateTime(2018, 5, 23, 22, 56, 28, 0);
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeFin.Location = new System.Drawing.Point(150, 154);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.ShowUpDown = true;
            this.dateTimeFin.Size = new System.Drawing.Size(195, 29);
            this.dateTimeFin.TabIndex = 92;
            this.dateTimeFin.Value = new System.DateTime(2018, 5, 23, 22, 56, 28, 0);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnInsertar.Location = new System.Drawing.Point(514, 166);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(150, 57);
            this.btnInsertar.TabIndex = 93;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(188, 208);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 24);
            this.lblTotal.TabIndex = 95;
            this.lblTotal.Text = "Total : ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 203);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 96;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 463);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeinicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnEliminaralultimo);
            this.Controls.Add(this.btnEliminarprimero);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarFinal);
            this.Controls.Add(this.txtNombreBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminaralultimo;
        private System.Windows.Forms.Button btnEliminarprimero;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeinicio;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}


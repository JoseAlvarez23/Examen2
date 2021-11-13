
namespace EXAMEN2_PARCIAL2.Vistas
{
    partial class SoporteView
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idservicios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tiposoporte = new System.Windows.Forms.ComboBox();
            this.txt_dispositivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminarsoporte = new System.Windows.Forms.Button();
            this.btn_modificarsoporte = new System.Windows.Forms.Button();
            this.btn_cancelarsoporte = new System.Windows.Forms.Button();
            this.btn_guardarsoporte = new System.Windows.Forms.Button();
            this.btn_nuevosoporte = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "SERVICIOS DE LA EMPRESA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "TIPO DE SOPORTE QUE QUIERE:";
            // 
            // txt_idservicios
            // 
            this.txt_idservicios.Location = new System.Drawing.Point(327, 103);
            this.txt_idservicios.Name = "txt_idservicios";
            this.txt_idservicios.Size = new System.Drawing.Size(218, 20);
            this.txt_idservicios.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cb_tiposoporte
            // 
            this.cb_tiposoporte.FormattingEnabled = true;
            this.cb_tiposoporte.Items.AddRange(new object[] {
            "LIMPIEZA",
            "MANTANIMIENTO",
            "REPARACION"});
            this.cb_tiposoporte.Location = new System.Drawing.Point(327, 219);
            this.cb_tiposoporte.Name = "cb_tiposoporte";
            this.cb_tiposoporte.Size = new System.Drawing.Size(218, 21);
            this.cb_tiposoporte.TabIndex = 43;
            // 
            // txt_dispositivo
            // 
            this.txt_dispositivo.Location = new System.Drawing.Point(327, 161);
            this.txt_dispositivo.Name = "txt_dispositivo";
            this.txt_dispositivo.Size = new System.Drawing.Size(218, 20);
            this.txt_dispositivo.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "DISPOSITIVO:";
            // 
            // btn_eliminarsoporte
            // 
            this.btn_eliminarsoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarsoporte.Location = new System.Drawing.Point(493, 304);
            this.btn_eliminarsoporte.Name = "btn_eliminarsoporte";
            this.btn_eliminarsoporte.Size = new System.Drawing.Size(115, 67);
            this.btn_eliminarsoporte.TabIndex = 50;
            this.btn_eliminarsoporte.Text = "ELIMINAR";
            this.btn_eliminarsoporte.UseVisualStyleBackColor = true;
            // 
            // btn_modificarsoporte
            // 
            this.btn_modificarsoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarsoporte.Location = new System.Drawing.Point(193, 304);
            this.btn_modificarsoporte.Name = "btn_modificarsoporte";
            this.btn_modificarsoporte.Size = new System.Drawing.Size(115, 67);
            this.btn_modificarsoporte.TabIndex = 49;
            this.btn_modificarsoporte.Text = "MODIFICAR";
            this.btn_modificarsoporte.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarsoporte
            // 
            this.btn_cancelarsoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarsoporte.Location = new System.Drawing.Point(644, 304);
            this.btn_cancelarsoporte.Name = "btn_cancelarsoporte";
            this.btn_cancelarsoporte.Size = new System.Drawing.Size(115, 67);
            this.btn_cancelarsoporte.TabIndex = 48;
            this.btn_cancelarsoporte.Text = "CANCELAR";
            this.btn_cancelarsoporte.UseVisualStyleBackColor = true;
            // 
            // btn_guardarsoporte
            // 
            this.btn_guardarsoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarsoporte.Location = new System.Drawing.Point(342, 304);
            this.btn_guardarsoporte.Name = "btn_guardarsoporte";
            this.btn_guardarsoporte.Size = new System.Drawing.Size(130, 67);
            this.btn_guardarsoporte.TabIndex = 47;
            this.btn_guardarsoporte.Text = "GUARDAR";
            this.btn_guardarsoporte.UseVisualStyleBackColor = true;
            // 
            // btn_nuevosoporte
            // 
            this.btn_nuevosoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevosoporte.Location = new System.Drawing.Point(25, 304);
            this.btn_nuevosoporte.Name = "btn_nuevosoporte";
            this.btn_nuevosoporte.Size = new System.Drawing.Size(130, 67);
            this.btn_nuevosoporte.TabIndex = 46;
            this.btn_nuevosoporte.Text = "NUEVO";
            this.btn_nuevosoporte.UseVisualStyleBackColor = true;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // SoporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminarsoporte);
            this.Controls.Add(this.btn_modificarsoporte);
            this.Controls.Add(this.btn_cancelarsoporte);
            this.Controls.Add(this.btn_guardarsoporte);
            this.Controls.Add(this.btn_nuevosoporte);
            this.Controls.Add(this.txt_dispositivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tiposoporte);
            this.Controls.Add(this.txt_idservicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "SoporteView";
            this.Text = "TIPO DE SOPORTES";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_idservicios;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_tiposoporte;
        public System.Windows.Forms.TextBox txt_dispositivo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_eliminarsoporte;
        public System.Windows.Forms.Button btn_modificarsoporte;
        public System.Windows.Forms.Button btn_cancelarsoporte;
        public System.Windows.Forms.Button btn_guardarsoporte;
        public System.Windows.Forms.Button btn_nuevosoporte;
        public System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
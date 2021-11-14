
namespace EXAMEN2_PARCIAL2.Vistas
{
    partial class EstadoTicketsViewcs
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
            this.txt_idestado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminarestado = new System.Windows.Forms.Button();
            this.btn_modificarestado = new System.Windows.Forms.Button();
            this.btn_cancelarestado = new System.Windows.Forms.Button();
            this.btn_guardarestado = new System.Windows.Forms.Button();
            this.btn_nuevoestado = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "ESTADO DE TICKET";
            // 
            // txt_idestado
            // 
            this.txt_idestado.Location = new System.Drawing.Point(343, 114);
            this.txt_idestado.Name = "txt_idestado";
            this.txt_idestado.ReadOnly = true;
            this.txt_idestado.Size = new System.Drawing.Size(218, 20);
            this.txt_idestado.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID:";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "SIN RESOLVER",
            "ABIERTO",
            "EN ESPERA",
            "CERRADO"});
            this.cb_estado.Location = new System.Drawing.Point(348, 209);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(218, 21);
            this.cb_estado.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "ESTADO DE SU TICKET:";
            // 
            // btn_eliminarestado
            // 
            this.btn_eliminarestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarestado.Location = new System.Drawing.Point(502, 304);
            this.btn_eliminarestado.Name = "btn_eliminarestado";
            this.btn_eliminarestado.Size = new System.Drawing.Size(130, 44);
            this.btn_eliminarestado.TabIndex = 52;
            this.btn_eliminarestado.Text = "ELIMINAR";
            this.btn_eliminarestado.UseVisualStyleBackColor = true;
            // 
            // btn_modificarestado
            // 
            this.btn_modificarestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarestado.Location = new System.Drawing.Point(202, 304);
            this.btn_modificarestado.Name = "btn_modificarestado";
            this.btn_modificarestado.Size = new System.Drawing.Size(130, 44);
            this.btn_modificarestado.TabIndex = 51;
            this.btn_modificarestado.Text = "MODIFICAR";
            this.btn_modificarestado.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarestado
            // 
            this.btn_cancelarestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarestado.Location = new System.Drawing.Point(653, 304);
            this.btn_cancelarestado.Name = "btn_cancelarestado";
            this.btn_cancelarestado.Size = new System.Drawing.Size(130, 44);
            this.btn_cancelarestado.TabIndex = 50;
            this.btn_cancelarestado.Text = "CANCELAR";
            this.btn_cancelarestado.UseVisualStyleBackColor = true;
            // 
            // btn_guardarestado
            // 
            this.btn_guardarestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarestado.Location = new System.Drawing.Point(351, 304);
            this.btn_guardarestado.Name = "btn_guardarestado";
            this.btn_guardarestado.Size = new System.Drawing.Size(145, 44);
            this.btn_guardarestado.TabIndex = 49;
            this.btn_guardarestado.Text = "GUARDAR";
            this.btn_guardarestado.UseVisualStyleBackColor = true;
            // 
            // btn_nuevoestado
            // 
            this.btn_nuevoestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoestado.Location = new System.Drawing.Point(34, 304);
            this.btn_nuevoestado.Name = "btn_nuevoestado";
            this.btn_nuevoestado.Size = new System.Drawing.Size(145, 44);
            this.btn_nuevoestado.TabIndex = 48;
            this.btn_nuevoestado.Text = "NUEVO";
            this.btn_nuevoestado.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstadoTicketsViewcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminarestado);
            this.Controls.Add(this.btn_modificarestado);
            this.Controls.Add(this.btn_cancelarestado);
            this.Controls.Add(this.btn_guardarestado);
            this.Controls.Add(this.btn_nuevoestado);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idestado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "EstadoTicketsViewcs";
            this.Text = "EstadoTicketsViewcs";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_idestado;
        public System.Windows.Forms.ComboBox cb_estado;
        public System.Windows.Forms.Button btn_eliminarestado;
        public System.Windows.Forms.Button btn_modificarestado;
        public System.Windows.Forms.Button btn_cancelarestado;
        public System.Windows.Forms.Button btn_guardarestado;
        public System.Windows.Forms.Button btn_nuevoestado;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
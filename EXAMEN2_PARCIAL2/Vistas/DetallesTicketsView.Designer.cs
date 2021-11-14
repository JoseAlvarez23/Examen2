
namespace EXAMEN2_PARCIAL2.Vistas
{
    partial class DetallesTicketsView
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
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_iddetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_estadodetalle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_asuntodetalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numerodetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombredetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_eliminardetalle = new System.Windows.Forms.Button();
            this.btn_modificardetalle = new System.Windows.Forms.Button();
            this.btn_cancelardetalle = new System.Windows.Forms.Button();
            this.btn_guardardetalle = new System.Windows.Forms.Button();
            this.btn_nuevodetalle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "DETALLES DE TICKET";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(-1, 332);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(944, 166);
            this.DetalledataGridView.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "TODOS LOS TICKETS GENERADOS ";
            // 
            // txt_iddetalle
            // 
            this.txt_iddetalle.Location = new System.Drawing.Point(122, 80);
            this.txt_iddetalle.Name = "txt_iddetalle";
            this.txt_iddetalle.ReadOnly = true;
            this.txt_iddetalle.Size = new System.Drawing.Size(218, 20);
            this.txt_iddetalle.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID:";
            // 
            // cb_estadodetalle
            // 
            this.cb_estadodetalle.FormattingEnabled = true;
            this.cb_estadodetalle.Items.AddRange(new object[] {
            "SIN RESOLVER",
            "ABIERTO",
            "EN ESPERA",
            "CERRADO"});
            this.cb_estadodetalle.Location = new System.Drawing.Point(679, 119);
            this.cb_estadodetalle.Name = "cb_estadodetalle";
            this.cb_estadodetalle.Size = new System.Drawing.Size(218, 21);
            this.cb_estadodetalle.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "ESTADO DEL TICKET GENERADO:";
            // 
            // txt_asuntodetalle
            // 
            this.txt_asuntodetalle.Location = new System.Drawing.Point(679, 73);
            this.txt_asuntodetalle.Name = "txt_asuntodetalle";
            this.txt_asuntodetalle.Size = new System.Drawing.Size(218, 20);
            this.txt_asuntodetalle.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(579, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "ASUNTO:";
            // 
            // txt_numerodetalle
            // 
            this.txt_numerodetalle.Location = new System.Drawing.Point(264, 167);
            this.txt_numerodetalle.Name = "txt_numerodetalle";
            this.txt_numerodetalle.Size = new System.Drawing.Size(218, 20);
            this.txt_numerodetalle.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "NOMBRE:";
            // 
            // txt_nombredetalle
            // 
            this.txt_nombredetalle.Location = new System.Drawing.Point(122, 123);
            this.txt_nombredetalle.Name = "txt_nombredetalle";
            this.txt_nombredetalle.Size = new System.Drawing.Size(218, 20);
            this.txt_nombredetalle.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "NUMERO DEL TICKET GENERADO:";
            // 
            // btn_eliminardetalle
            // 
            this.btn_eliminardetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminardetalle.Location = new System.Drawing.Point(564, 228);
            this.btn_eliminardetalle.Name = "btn_eliminardetalle";
            this.btn_eliminardetalle.Size = new System.Drawing.Size(130, 44);
            this.btn_eliminardetalle.TabIndex = 60;
            this.btn_eliminardetalle.Text = "ELIMINAR";
            this.btn_eliminardetalle.UseVisualStyleBackColor = true;
            // 
            // btn_modificardetalle
            // 
            this.btn_modificardetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificardetalle.Location = new System.Drawing.Point(264, 228);
            this.btn_modificardetalle.Name = "btn_modificardetalle";
            this.btn_modificardetalle.Size = new System.Drawing.Size(130, 44);
            this.btn_modificardetalle.TabIndex = 59;
            this.btn_modificardetalle.Text = "MODIFICAR";
            this.btn_modificardetalle.UseVisualStyleBackColor = true;
            // 
            // btn_cancelardetalle
            // 
            this.btn_cancelardetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelardetalle.Location = new System.Drawing.Point(715, 228);
            this.btn_cancelardetalle.Name = "btn_cancelardetalle";
            this.btn_cancelardetalle.Size = new System.Drawing.Size(130, 44);
            this.btn_cancelardetalle.TabIndex = 58;
            this.btn_cancelardetalle.Text = "CANCELAR";
            this.btn_cancelardetalle.UseVisualStyleBackColor = true;
            // 
            // btn_guardardetalle
            // 
            this.btn_guardardetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardardetalle.Location = new System.Drawing.Point(413, 228);
            this.btn_guardardetalle.Name = "btn_guardardetalle";
            this.btn_guardardetalle.Size = new System.Drawing.Size(145, 44);
            this.btn_guardardetalle.TabIndex = 57;
            this.btn_guardardetalle.Text = "GUARDAR";
            this.btn_guardardetalle.UseVisualStyleBackColor = true;
            // 
            // btn_nuevodetalle
            // 
            this.btn_nuevodetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevodetalle.Location = new System.Drawing.Point(96, 228);
            this.btn_nuevodetalle.Name = "btn_nuevodetalle";
            this.btn_nuevodetalle.Size = new System.Drawing.Size(145, 44);
            this.btn_nuevodetalle.TabIndex = 56;
            this.btn_nuevodetalle.Text = "NUEVO";
            this.btn_nuevodetalle.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DetallesTicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(940, 501);
            this.Controls.Add(this.btn_eliminardetalle);
            this.Controls.Add(this.btn_modificardetalle);
            this.Controls.Add(this.btn_cancelardetalle);
            this.Controls.Add(this.btn_guardardetalle);
            this.Controls.Add(this.btn_nuevodetalle);
            this.Controls.Add(this.txt_asuntodetalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_numerodetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombredetalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_estadodetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_iddetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.label2);
            this.Name = "DetallesTicketsView";
            this.Text = "DETALLES DE LOS TICKETS";
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DetalledataGridView;
        public System.Windows.Forms.TextBox txt_iddetalle;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_estadodetalle;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_asuntodetalle;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_numerodetalle;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_nombredetalle;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn_eliminardetalle;
        public System.Windows.Forms.Button btn_modificardetalle;
        public System.Windows.Forms.Button btn_cancelardetalle;
        public System.Windows.Forms.Button btn_guardardetalle;
        public System.Windows.Forms.Button btn_nuevodetalle;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
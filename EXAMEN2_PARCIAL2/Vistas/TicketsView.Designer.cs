
namespace EXAMEN2_PARCIAL2.Vistas
{
    partial class TicketsView
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
            this.txt_nombreticket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idticket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_asunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numeroticket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_eliminarticket = new System.Windows.Forms.Button();
            this.btn_modificarticket = new System.Windows.Forms.Button();
            this.btn_cancelarticket = new System.Windows.Forms.Button();
            this.btn_guadarticket = new System.Windows.Forms.Button();
            this.btn_nuevoticket = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombreticket
            // 
            this.txt_nombreticket.Location = new System.Drawing.Point(402, 139);
            this.txt_nombreticket.Name = "txt_nombreticket";
            this.txt_nombreticket.Size = new System.Drawing.Size(218, 20);
            this.txt_nombreticket.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "NUMERO DEL TICKET:";
            // 
            // txt_idticket
            // 
            this.txt_idticket.Location = new System.Drawing.Point(402, 87);
            this.txt_idticket.Name = "txt_idticket";
            this.txt_idticket.ReadOnly = true;
            this.txt_idticket.Size = new System.Drawing.Size(218, 20);
            this.txt_idticket.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "GENERAR EL TICKET";
            // 
            // txt_asunto
            // 
            this.txt_asunto.Location = new System.Drawing.Point(402, 230);
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(218, 20);
            this.txt_asunto.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "ASUNTO:";
            // 
            // txt_numeroticket
            // 
            this.txt_numeroticket.Location = new System.Drawing.Point(402, 178);
            this.txt_numeroticket.Name = "txt_numeroticket";
            this.txt_numeroticket.Size = new System.Drawing.Size(218, 20);
            this.txt_numeroticket.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "NOMBRE:";
            // 
            // btn_eliminarticket
            // 
            this.btn_eliminarticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarticket.Location = new System.Drawing.Point(535, 302);
            this.btn_eliminarticket.Name = "btn_eliminarticket";
            this.btn_eliminarticket.Size = new System.Drawing.Size(130, 44);
            this.btn_eliminarticket.TabIndex = 46;
            this.btn_eliminarticket.Text = "ELIMINAR";
            this.btn_eliminarticket.UseVisualStyleBackColor = true;
            // 
            // btn_modificarticket
            // 
            this.btn_modificarticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarticket.Location = new System.Drawing.Point(235, 302);
            this.btn_modificarticket.Name = "btn_modificarticket";
            this.btn_modificarticket.Size = new System.Drawing.Size(130, 44);
            this.btn_modificarticket.TabIndex = 45;
            this.btn_modificarticket.Text = "MODIFICAR";
            this.btn_modificarticket.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarticket
            // 
            this.btn_cancelarticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarticket.Location = new System.Drawing.Point(686, 302);
            this.btn_cancelarticket.Name = "btn_cancelarticket";
            this.btn_cancelarticket.Size = new System.Drawing.Size(130, 44);
            this.btn_cancelarticket.TabIndex = 44;
            this.btn_cancelarticket.Text = "CANCELAR";
            this.btn_cancelarticket.UseVisualStyleBackColor = true;
            // 
            // btn_guadarticket
            // 
            this.btn_guadarticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guadarticket.Location = new System.Drawing.Point(384, 302);
            this.btn_guadarticket.Name = "btn_guadarticket";
            this.btn_guadarticket.Size = new System.Drawing.Size(145, 44);
            this.btn_guadarticket.TabIndex = 43;
            this.btn_guadarticket.Text = "GUARDAR";
            this.btn_guadarticket.UseVisualStyleBackColor = true;
            // 
            // btn_nuevoticket
            // 
            this.btn_nuevoticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoticket.Location = new System.Drawing.Point(67, 302);
            this.btn_nuevoticket.Name = "btn_nuevoticket";
            this.btn_nuevoticket.Size = new System.Drawing.Size(145, 44);
            this.btn_nuevoticket.TabIndex = 42;
            this.btn_nuevoticket.Text = "NUEVO";
            this.btn_nuevoticket.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.btn_eliminarticket);
            this.Controls.Add(this.btn_modificarticket);
            this.Controls.Add(this.btn_cancelarticket);
            this.Controls.Add(this.btn_guadarticket);
            this.Controls.Add(this.btn_nuevoticket);
            this.Controls.Add(this.txt_asunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numeroticket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombreticket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idticket);
            this.Controls.Add(this.label1);
            this.Name = "TicketsView";
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_eliminarticket;
        public System.Windows.Forms.Button btn_modificarticket;
        public System.Windows.Forms.Button btn_cancelarticket;
        public System.Windows.Forms.Button btn_guadarticket;
        public System.Windows.Forms.Button btn_nuevoticket;
        public System.Windows.Forms.TextBox txt_asunto;
        public System.Windows.Forms.TextBox txt_numeroticket;
        public System.Windows.Forms.TextBox txt_nombreticket;
        public System.Windows.Forms.TextBox txt_idticket;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
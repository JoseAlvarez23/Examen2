
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
            this.label2 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_iddetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 26);
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
            this.DetalledataGridView.Location = new System.Drawing.Point(-1, 264);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(944, 234);
            this.DetalledataGridView.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "TODOS LOS TICKETS GENERADOS ";
            // 
            // txt_iddetalle
            // 
            this.txt_iddetalle.Location = new System.Drawing.Point(341, 100);
            this.txt_iddetalle.Name = "txt_iddetalle";
            this.txt_iddetalle.ReadOnly = true;
            this.txt_iddetalle.Size = new System.Drawing.Size(218, 20);
            this.txt_iddetalle.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID:";
            // 
            // DetallesTicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(940, 501);
            this.Controls.Add(this.txt_iddetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.label2);
            this.Name = "DetallesTicketsView";
            this.Text = "DETALLES DE LOS TICKETS";
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DetalledataGridView;
        public System.Windows.Forms.TextBox txt_iddetalle;
        private System.Windows.Forms.Label label3;
    }
}
namespace GeoInteractiva
{
    partial class FormRombo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.Label lblD2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtD1
            // 
            this.txtD1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD1.Location = new System.Drawing.Point(130, 20);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(100, 23);
            this.txtD1.TabIndex = 0;
            // 
            // txtD2
            // 
            this.txtD2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD2.Location = new System.Drawing.Point(130, 50);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(100, 23);
            this.txtD2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(20, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotar.Location = new System.Drawing.Point(110, 90);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(75, 23);
            this.btnRotar.TabIndex = 3;
            this.btnRotar.Text = "Rotar";
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // btnEscalar
            // 
            this.btnEscalar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscalar.Location = new System.Drawing.Point(200, 90);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(75, 23);
            this.btnEscalar.TabIndex = 4;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(20, 130);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(300, 20);
            this.lblArea.TabIndex = 5;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(20, 150);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(300, 20);
            this.lblPerimetro.TabIndex = 6;
            this.lblPerimetro.Click += new System.EventHandler(this.lblPerimetro_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDibujo.Location = new System.Drawing.Point(20, 190);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(545, 246);
            this.panelDibujo.TabIndex = 7;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblD1
            // 
            this.lblD1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD1.Location = new System.Drawing.Point(20, 20);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(100, 23);
            this.lblD1.TabIndex = 8;
            this.lblD1.Text = "Diagonal Mayor:";
            // 
            // lblD2
            // 
            this.lblD2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD2.Location = new System.Drawing.Point(20, 50);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(100, 23);
            this.lblD2.TabIndex = 9;
            this.lblD2.Text = "Diagonal Menor:";
            // 
            // FormRombo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 480);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.btnEscalar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.lblD1);
            this.Controls.Add(this.lblD2);
            this.Name = "FormRombo";
            this.Text = "Rombo";
            this.Load += new System.EventHandler(this.FormRombo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRombo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

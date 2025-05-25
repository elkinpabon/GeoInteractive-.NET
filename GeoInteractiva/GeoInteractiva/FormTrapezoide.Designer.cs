namespace GeoInteractiva
{
    partial class FormTrapezoide
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnEscalar;

        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblBaseMayor;
        private System.Windows.Forms.Label lblBaseMenor;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;

        private System.Windows.Forms.Panel panelDibujo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblBaseMayor = new System.Windows.Forms.Label();
            this.lblBaseMenor = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseMayor.Location = new System.Drawing.Point(130, 20);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(100, 23);
            this.txtBaseMayor.TabIndex = 0;
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseMenor.Location = new System.Drawing.Point(130, 50);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(100, 23);
            this.txtBaseMenor.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(130, 80);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 2;
            // 
            // txtLado1
            // 
            this.txtLado1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado1.Location = new System.Drawing.Point(130, 110);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 23);
            this.txtLado1.TabIndex = 3;
            // 
            // txtLado2
            // 
            this.txtLado2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado2.Location = new System.Drawing.Point(130, 140);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 23);
            this.txtLado2.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(20, 180);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotar.Location = new System.Drawing.Point(110, 180);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(75, 23);
            this.btnRotar.TabIndex = 6;
            this.btnRotar.Text = "Rotar";
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // btnEscalar
            // 
            this.btnEscalar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscalar.Location = new System.Drawing.Point(200, 180);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(75, 23);
            this.btnEscalar.TabIndex = 7;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(281, 110);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(250, 22);
            this.lblArea.TabIndex = 8;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(281, 140);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(250, 22);
            this.lblPerimetro.TabIndex = 9;
            this.lblPerimetro.Click += new System.EventHandler(this.lblPerimetro_Click);
            // 
            // lblBaseMayor
            // 
            this.lblBaseMayor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMayor.Location = new System.Drawing.Point(20, 20);
            this.lblBaseMayor.Name = "lblBaseMayor";
            this.lblBaseMayor.Size = new System.Drawing.Size(100, 20);
            this.lblBaseMayor.TabIndex = 11;
            this.lblBaseMayor.Text = "Base Mayor:";
            // 
            // lblBaseMenor
            // 
            this.lblBaseMenor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMenor.Location = new System.Drawing.Point(20, 50);
            this.lblBaseMenor.Name = "lblBaseMenor";
            this.lblBaseMenor.Size = new System.Drawing.Size(100, 20);
            this.lblBaseMenor.TabIndex = 12;
            this.lblBaseMenor.Text = "Base Menor:";
            // 
            // lblAltura
            // 
            this.lblAltura.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(20, 80);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(100, 20);
            this.lblAltura.TabIndex = 13;
            this.lblAltura.Text = "Altura:";
            // 
            // lblLado1
            // 
            this.lblLado1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.Location = new System.Drawing.Point(20, 110);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(100, 20);
            this.lblLado1.TabIndex = 14;
            this.lblLado1.Text = "Lado 1:";
            // 
            // lblLado2
            // 
            this.lblLado2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.Location = new System.Drawing.Point(20, 140);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(100, 20);
            this.lblLado2.TabIndex = 15;
            this.lblLado2.Text = "Lado 2:";
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDibujo.Location = new System.Drawing.Point(20, 225);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(545, 216);
            this.panelDibujo.TabIndex = 10;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // FormTrapezoide
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 464);
            this.Controls.Add(this.txtBaseMayor);
            this.Controls.Add(this.txtBaseMenor);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.btnEscalar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.lblBaseMayor);
            this.Controls.Add(this.lblBaseMenor);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.lblLado2);
            this.Name = "FormTrapezoide";
            this.Text = "Trapezoide";
            this.Load += new System.EventHandler(this.FormTrapezoide_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTrapezoide_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

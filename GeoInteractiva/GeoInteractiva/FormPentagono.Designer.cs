namespace GeoInteractiva
{
    partial class FormPentagono
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblApotema;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblApotema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLado
            // 
            this.txtLado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado.Location = new System.Drawing.Point(130, 20);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 23);
            this.txtLado.TabIndex = 0;
            // 
            // txtApotema
            // 
            this.txtApotema.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApotema.Location = new System.Drawing.Point(130, 50);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(100, 23);
            this.txtApotema.TabIndex = 1;
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
            // 
            // panelDibujo
            // 
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDibujo.Location = new System.Drawing.Point(20, 190);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(548, 250);
            this.panelDibujo.TabIndex = 7;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblLado
            // 
            this.lblLado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(20, 20);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(100, 23);
            this.lblLado.TabIndex = 8;
            this.lblLado.Text = "Lado:";
            // 
            // lblApotema
            // 
            this.lblApotema.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApotema.Location = new System.Drawing.Point(20, 50);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(100, 23);
            this.lblApotema.TabIndex = 9;
            this.lblApotema.Text = "Apotema:";
            // 
            // FormPentagono
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.btnEscalar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblApotema);
            this.Name = "FormPentagono";
            this.Text = "Pentágono";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPentagono_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

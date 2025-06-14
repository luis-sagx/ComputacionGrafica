namespace GeometricFigures
{
    partial class FrmFiguraPitag
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInputs = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(287, 267);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 45);
            this.btnBack.TabIndex = 108;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.ForeColor = System.Drawing.Color.Snow;
            this.btnReset.Location = new System.Drawing.Point(158, 267);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 45);
            this.btnReset.TabIndex = 107;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDibujar.ForeColor = System.Drawing.Color.Azure;
            this.btnDibujar.Location = new System.Drawing.Point(11, 267);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(115, 45);
            this.btnDibujar.TabIndex = 106;
            this.btnDibujar.Text = "Calculate";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(-39, 3);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(390, 6, 390, 6);
            this.lblTitulo.Size = new System.Drawing.Size(989, 48);
            this.lblTitulo.TabIndex = 105;
            this.lblTitulo.Text = "Drawing Circle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "----------------------------------------------------------------------------";
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInputs.Location = new System.Drawing.Point(6, 113);
            this.lblInputs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(55, 25);
            this.lblInputs.TabIndex = 101;
            this.lblInputs.Text = "Input";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.AliceBlue;
            this.picCanvas.Location = new System.Drawing.Point(455, 94);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(450, 440);
            this.picCanvas.TabIndex = 100;
            this.picCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(24, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 97;
            this.label1.Text = "Radius (m):";
            // 
            // txtRadio
            // 
            this.txtRadio.BackColor = System.Drawing.Color.Lavender;
            this.txtRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtRadio.Location = new System.Drawing.Point(171, 158);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(132, 28);
            this.txtRadio.TabIndex = 94;
            // 
            // FrmFiguraPitag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 574);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadio);
            this.Name = "FrmFiguraPitag";
            this.Text = "FrmFiguraPitag";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
    }
}
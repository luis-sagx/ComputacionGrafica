namespace Sagnay_Luis_Ex2
{
    partial class FrmPaint
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCircunferencia = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnRelleno = new System.Windows.Forms.Button();
            this.btnRecorte = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(-18, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(330, 8, 330, 8);
            this.lblTitulo.Size = new System.Drawing.Size(986, 47);
            this.lblTitulo.TabIndex = 59;
            this.lblTitulo.Text = "Welcome to the mini Paint";
            // 
            // btnLinea
            // 
            this.btnLinea.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLinea.ForeColor = System.Drawing.Color.White;
            this.btnLinea.Location = new System.Drawing.Point(32, 96);
            this.btnLinea.Margin = new System.Windows.Forms.Padding(4);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(95, 43);
            this.btnLinea.TabIndex = 60;
            this.btnLinea.Text = "Line";
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCircunferencia
            // 
            this.btnCircunferencia.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCircunferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCircunferencia.ForeColor = System.Drawing.Color.White;
            this.btnCircunferencia.Location = new System.Drawing.Point(153, 96);
            this.btnCircunferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircunferencia.Name = "btnCircunferencia";
            this.btnCircunferencia.Size = new System.Drawing.Size(95, 43);
            this.btnCircunferencia.TabIndex = 61;
            this.btnCircunferencia.Text = "Circle";
            this.btnCircunferencia.UseVisualStyleBackColor = false;
            this.btnCircunferencia.Click += new System.EventHandler(this.btnCircunferencia_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBezier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBezier.ForeColor = System.Drawing.Color.White;
            this.btnBezier.Location = new System.Drawing.Point(269, 96);
            this.btnBezier.Margin = new System.Windows.Forms.Padding(4);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(139, 43);
            this.btnBezier.TabIndex = 62;
            this.btnBezier.Text = "Cubic Curve";
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnRelleno
            // 
            this.btnRelleno.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRelleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRelleno.ForeColor = System.Drawing.Color.White;
            this.btnRelleno.Location = new System.Drawing.Point(428, 96);
            this.btnRelleno.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(95, 43);
            this.btnRelleno.TabIndex = 63;
            this.btnRelleno.Text = "Clip";
            this.btnRelleno.UseVisualStyleBackColor = false;
            this.btnRelleno.Click += new System.EventHandler(this.btnRecorte_Click);
            // 
            // btnRecorte
            // 
            this.btnRecorte.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRecorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRecorte.ForeColor = System.Drawing.Color.White;
            this.btnRecorte.Location = new System.Drawing.Point(542, 96);
            this.btnRecorte.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecorte.Name = "btnRecorte";
            this.btnRecorte.Size = new System.Drawing.Size(95, 43);
            this.btnRecorte.TabIndex = 64;
            this.btnRecorte.Text = "Fill";
            this.btnRecorte.UseVisualStyleBackColor = false;
            this.btnRecorte.Click += new System.EventHandler(this.btnRelleno_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(32, 176);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(875, 434);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(812, 96);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 43);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(709, 96);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(95, 43);
            this.btnColor.TabIndex = 66;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // FrmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 648);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRecorte);
            this.Controls.Add(this.btnRelleno);
            this.Controls.Add(this.btnBezier);
            this.Controls.Add(this.btnCircunferencia);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmPaint";
            this.Text = "FrmPain";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCircunferencia;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnRelleno;
        private System.Windows.Forms.Button btnRecorte;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
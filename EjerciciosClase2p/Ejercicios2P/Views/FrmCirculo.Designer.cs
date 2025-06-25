namespace Ejercicios2P.DrawCircle
{
    partial class FrmCirculo
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
            this.dataGridViewPuntos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuntoy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInputs = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtPuntox = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPuntos
            // 
            this.dataGridViewPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPuntos.Location = new System.Drawing.Point(732, 124);
            this.dataGridViewPuntos.Name = "dataGridViewPuntos";
            this.dataGridViewPuntos.RowHeadersWidth = 51;
            this.dataGridViewPuntos.RowTemplate.Height = 24;
            this.dataGridViewPuntos.Size = new System.Drawing.Size(316, 423);
            this.dataGridViewPuntos.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(46, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "Center Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(65, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "y";
            // 
            // txtPuntoy
            // 
            this.txtPuntoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPuntoy.Location = new System.Drawing.Point(115, 257);
            this.txtPuntoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuntoy.Name = "txtPuntoy";
            this.txtPuntoy.Size = new System.Drawing.Size(108, 28);
            this.txtPuntoy.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "----------------------------------------";
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInputs.Location = new System.Drawing.Point(31, 120);
            this.lblInputs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(55, 25);
            this.lblInputs.TabIndex = 58;
            this.lblInputs.Text = "Input";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(-82, 33);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(445, 8, 445, 8);
            this.lblTitulo.Size = new System.Drawing.Size(1246, 47);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "Draw Circle with Bresenham";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(37, 504);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 43);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(37, 445);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(213, 43);
            this.btnCalculate.TabIndex = 55;
            this.btnCalculate.Text = "Draw and Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(46, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(65, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "x";
            // 
            // txtRadius
            // 
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtRadius.Location = new System.Drawing.Point(115, 303);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(108, 28);
            this.txtRadius.TabIndex = 49;
            // 
            // txtPuntox
            // 
            this.txtPuntox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPuntox.Location = new System.Drawing.Point(115, 214);
            this.txtPuntox.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuntox.Name = "txtPuntox";
            this.txtPuntox.Size = new System.Drawing.Size(108, 28);
            this.txtPuntox.TabIndex = 48;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.AliceBlue;
            this.picCanvas.Location = new System.Drawing.Point(288, 126);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(424, 423);
            this.picCanvas.TabIndex = 54;
            this.picCanvas.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(150, 504);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 43);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 593);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewPuntos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuntoy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtPuntox);
            this.Name = "FrmCirculo";
            this.Text = "FrmCircle";
            this.Load += new System.EventHandler(this.FrmCirculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPuntos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuntoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtPuntox;
        private System.Windows.Forms.Button btnBack;
    }
}
namespace Ejercicios2P.Views
{
    partial class FrmFloodFill
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
            this.lblInput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInputs = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPuntos
            // 
            this.dataGridViewPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPuntos.Location = new System.Drawing.Point(732, 123);
            this.dataGridViewPuntos.Name = "dataGridViewPuntos";
            this.dataGridViewPuntos.RowHeadersWidth = 51;
            this.dataGridViewPuntos.RowTemplate.Height = 24;
            this.dataGridViewPuntos.Size = new System.Drawing.Size(316, 423);
            this.dataGridViewPuntos.TabIndex = 64;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblInput.Location = new System.Drawing.Point(46, 190);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(148, 24);
            this.lblInput.TabIndex = 62;
            this.lblInput.Text = "Number of sides";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 125);
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
            this.lblInputs.Location = new System.Drawing.Point(31, 119);
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
            this.lblTitulo.Location = new System.Drawing.Point(-38, 32);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(445, 8, 445, 8);
            this.lblTitulo.Size = new System.Drawing.Size(1159, 47);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "Draw and Fill Poligon";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(36, 500);
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
            this.btnCalculate.Location = new System.Drawing.Point(36, 448);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(214, 43);
            this.btnCalculate.TabIndex = 55;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSides
            // 
            this.txtSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSides.Location = new System.Drawing.Point(50, 233);
            this.txtSides.Margin = new System.Windows.Forms.Padding(4);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(149, 28);
            this.txtSides.TabIndex = 48;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.AliceBlue;
            this.picCanvas.Location = new System.Drawing.Point(313, 214);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(383, 334);
            this.picCanvas.TabIndex = 54;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(150, 500);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 43);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarning.Location = new System.Drawing.Point(308, 140);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(375, 25);
            this.lblWarning.TabIndex = 66;
            this.lblWarning.Text = "Only if the polygon is already created,";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(309, 170);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(324, 20);
            this.lblInfo.TabIndex = 67;
            this.lblInfo.Text = "click inside the polygon and see the magic";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblcolor.Location = new System.Drawing.Point(46, 300);
            this.lblcolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(186, 24);
            this.lblcolor.TabIndex = 68;
            this.lblcolor.Text = "Select the color to fill:";
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSelectColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectColor.Location = new System.Drawing.Point(36, 338);
            this.btnSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(214, 43);
            this.btnSelectColor.TabIndex = 69;
            this.btnSelectColor.Text = "Fill Color";
            this.btnSelectColor.UseVisualStyleBackColor = false;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // FrmFloodFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 593);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewPuntos);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.txtSides);
            this.Name = "FrmFloodFill";
            this.Text = "FrmFloodFill";
            this.Load += new System.EventHandler(this.FrmFloodFill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPuntos;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
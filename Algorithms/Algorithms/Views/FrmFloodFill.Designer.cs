﻿namespace Algorithms.Views
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
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInputs = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRecursive = new System.Windows.Forms.RadioButton();
            this.rbIterative = new System.Windows.Forms.RadioButton();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSelectColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectColor.Location = new System.Drawing.Point(232, 379);
            this.btnSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(121, 43);
            this.btnSelectColor.TabIndex = 81;
            this.btnSelectColor.Text = "Fill Color";
            this.btnSelectColor.UseVisualStyleBackColor = false;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblcolor.Location = new System.Drawing.Point(56, 389);
            this.lblcolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(101, 24);
            this.lblcolor.TabIndex = 80;
            this.lblcolor.Text = "Color to fill:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(412, 140);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(272, 18);
            this.lblInfo.TabIndex = 79;
            this.lblInfo.Text = "click inside the shape and see the magic";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarning.Location = new System.Drawing.Point(411, 116);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(334, 22);
            this.lblWarning.TabIndex = 78;
            this.lblWarning.Text = "Only if the shape is already created,";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblInput.Location = new System.Drawing.Point(56, 322);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(153, 24);
            this.lblInput.TabIndex = 76;
            this.lblInput.Text = "Number of sides:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "----------------------------------------";
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInputs.Location = new System.Drawing.Point(55, 134);
            this.lblInputs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(55, 25);
            this.lblInputs.TabIndex = 74;
            this.lblInputs.Text = "Input";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.AliceBlue;
            this.picCanvas.Location = new System.Drawing.Point(416, 169);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(423, 334);
            this.picCanvas.TabIndex = 71;
            this.picCanvas.TabStop = false;
            // 
            // txtSides
            // 
            this.txtSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSides.Location = new System.Drawing.Point(232, 322);
            this.txtSides.Margin = new System.Windows.Forms.Padding(4);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(121, 28);
            this.txtSides.TabIndex = 70;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(262, 460);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 43);
            this.btnBack.TabIndex = 84;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(159, 460);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 43);
            this.btnReset.TabIndex = 83;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(56, 460);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 43);
            this.btnCalculate.TabIndex = 82;
            this.btnCalculate.Text = "Draw ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(0, 32);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(390, 8, 390, 8);
            this.lblTitulo.Size = new System.Drawing.Size(904, 47);
            this.lblTitulo.TabIndex = 85;
            this.lblTitulo.Text = "Flood Fill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(56, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "Choose the shape:";
            // 
            // rbRecursive
            // 
            this.rbRecursive.AutoSize = true;
            this.rbRecursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecursive.Location = new System.Drawing.Point(60, 189);
            this.rbRecursive.Name = "rbRecursive";
            this.rbRecursive.Size = new System.Drawing.Size(111, 26);
            this.rbRecursive.TabIndex = 90;
            this.rbRecursive.TabStop = true;
            this.rbRecursive.Text = "Recursive";
            this.rbRecursive.UseVisualStyleBackColor = true;
            // 
            // rbIterative
            // 
            this.rbIterative.AutoSize = true;
            this.rbIterative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIterative.Location = new System.Drawing.Point(209, 189);
            this.rbIterative.Name = "rbIterative";
            this.rbIterative.Size = new System.Drawing.Size(94, 26);
            this.rbIterative.TabIndex = 89;
            this.rbIterative.TabStop = true;
            this.rbIterative.Text = "Iterative";
            this.rbIterative.UseVisualStyleBackColor = true;
            // 
            // cmbShape
            // 
            this.cmbShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(232, 258);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(121, 30);
            this.cmbShape.TabIndex = 91;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHelp.Location = new System.Drawing.Point(782, 37);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(57, 37);
            this.btnHelp.TabIndex = 92;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FrmFloodFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 553);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.cmbShape);
            this.Controls.Add(this.rbRecursive);
            this.Controls.Add(this.rbIterative);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.txtSides);
            this.Name = "FrmFloodFill";
            this.Text = "FrmFloodFill";
            this.Load += new System.EventHandler(this.FrmFloodFill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRecursive;
        private System.Windows.Forms.RadioButton rbIterative;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Button btnHelp;
    }
}
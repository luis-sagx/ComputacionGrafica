namespace Sagnay_Luis_Leccion2
{
    partial class FrmClock
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picCanvas.Location = new System.Drawing.Point(102, 91);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 400);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picCanvas_LoadCompleted);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(252, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Reloj";
            // 
            // btnInciar
            // 
            this.btnInciar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInciar.Location = new System.Drawing.Point(230, 529);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(144, 43);
            this.btnInciar.TabIndex = 2;
            this.btnInciar.Text = "Iniciar Reloj";
            this.btnInciar.UseVisualStyleBackColor = false;
            this.btnInciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // FrmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 606);
            this.Controls.Add(this.btnInciar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmClock";
            this.Text = "FrmClock";
            this.Load += new System.EventHandler(this.FrmClock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInciar;
    }
}
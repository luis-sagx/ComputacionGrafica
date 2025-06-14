namespace Ejercicios2P.Views
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineWithDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineWithBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cicleWithBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawAndFillPoligonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.floodFillToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineWithDDAToolStripMenuItem,
            this.lineWithBresenhamToolStripMenuItem});
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.lineToolStripMenuItem.Text = "Line";
            // 
            // lineWithDDAToolStripMenuItem
            // 
            this.lineWithDDAToolStripMenuItem.Name = "lineWithDDAToolStripMenuItem";
            this.lineWithDDAToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.lineWithDDAToolStripMenuItem.Text = "Line with DDA";
            this.lineWithDDAToolStripMenuItem.Click += new System.EventHandler(this.lineWithDDAToolStripMenuItem_Click);
            // 
            // lineWithBresenhamToolStripMenuItem
            // 
            this.lineWithBresenhamToolStripMenuItem.Name = "lineWithBresenhamToolStripMenuItem";
            this.lineWithBresenhamToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.lineWithBresenhamToolStripMenuItem.Text = "Line with Bresenham";
            this.lineWithBresenhamToolStripMenuItem.Click += new System.EventHandler(this.lineWithBresenhamToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cicleWithBresenhamToolStripMenuItem});
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.circleToolStripMenuItem.Text = "Circle";
            // 
            // cicleWithBresenhamToolStripMenuItem
            // 
            this.cicleWithBresenhamToolStripMenuItem.Name = "cicleWithBresenhamToolStripMenuItem";
            this.cicleWithBresenhamToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.cicleWithBresenhamToolStripMenuItem.Text = "Cicle with Bresenham";
            this.cicleWithBresenhamToolStripMenuItem.Click += new System.EventHandler(this.cicleWithBresenhamToolStripMenuItem_Click);
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawAndFillPoligonToolStripMenuItem});
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.floodFillToolStripMenuItem.Text = "FloodFill";
            // 
            // drawAndFillPoligonToolStripMenuItem
            // 
            this.drawAndFillPoligonToolStripMenuItem.Name = "drawAndFillPoligonToolStripMenuItem";
            this.drawAndFillPoligonToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.drawAndFillPoligonToolStripMenuItem.Text = "Draw and Fill Poligon";
            this.drawAndFillPoligonToolStripMenuItem.Click += new System.EventHandler(this.drawAndFillPoligonToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicios2P.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1082, 583);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineWithDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineWithBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cicleWithBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawAndFillPoligonToolStripMenuItem;
    }
}
namespace Algorithms.Views
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
            this.rasterizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineRasterizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curveRasterizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionFillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometricClippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametricCurvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillRecursiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineClippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonClippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineRasterizationToolStripMenuItem,
            this.curveRasterizationToolStripMenuItem,
            this.regionFillingToolStripMenuItem,
            this.geometricClippingToolStripMenuItem,
            this.parametricCurvesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rasterizacionToolStripMenuItem
            // 
            this.rasterizacionToolStripMenuItem.Name = "rasterizacionToolStripMenuItem";
            this.rasterizacionToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.rasterizacionToolStripMenuItem.Text = "Rasterizacion";
            // 
            // rellenoToolStripMenuItem
            // 
            this.rellenoToolStripMenuItem.Name = "rellenoToolStripMenuItem";
            this.rellenoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.rellenoToolStripMenuItem.Text = "Relleno";
            // 
            // recorteToolStripMenuItem
            // 
            this.recorteToolStripMenuItem.Name = "recorteToolStripMenuItem";
            this.recorteToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.recorteToolStripMenuItem.Text = "Recorte";
            // 
            // curvasToolStripMenuItem
            // 
            this.curvasToolStripMenuItem.Name = "curvasToolStripMenuItem";
            this.curvasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.curvasToolStripMenuItem.Text = "Curvas";
            // 
            // lineRasterizationToolStripMenuItem
            // 
            this.lineRasterizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem});
            this.lineRasterizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lineRasterizationToolStripMenuItem.Name = "lineRasterizationToolStripMenuItem";
            this.lineRasterizationToolStripMenuItem.Size = new System.Drawing.Size(158, 27);
            this.lineRasterizationToolStripMenuItem.Text = "Line Rasterization";
            // 
            // curveRasterizationToolStripMenuItem
            // 
            this.curveRasterizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.elipseToolStripMenuItem});
            this.curveRasterizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.curveRasterizationToolStripMenuItem.Name = "curveRasterizationToolStripMenuItem";
            this.curveRasterizationToolStripMenuItem.Size = new System.Drawing.Size(171, 27);
            this.curveRasterizationToolStripMenuItem.Text = "Curve Rasterization";
            // 
            // regionFillingToolStripMenuItem
            // 
            this.regionFillingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floodFillRecursiveToolStripMenuItem});
            this.regionFillingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.regionFillingToolStripMenuItem.Name = "regionFillingToolStripMenuItem";
            this.regionFillingToolStripMenuItem.Size = new System.Drawing.Size(126, 27);
            this.regionFillingToolStripMenuItem.Text = "Region Filling";
            // 
            // geometricClippingToolStripMenuItem
            // 
            this.geometricClippingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineClippingToolStripMenuItem,
            this.polygonClippingToolStripMenuItem});
            this.geometricClippingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.geometricClippingToolStripMenuItem.Name = "geometricClippingToolStripMenuItem";
            this.geometricClippingToolStripMenuItem.Size = new System.Drawing.Size(171, 27);
            this.geometricClippingToolStripMenuItem.Text = "Geometric Clipping";
            // 
            // parametricCurvesToolStripMenuItem
            // 
            this.parametricCurvesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bezierToolStripMenuItem});
            this.parametricCurvesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.parametricCurvesToolStripMenuItem.Name = "parametricCurvesToolStripMenuItem";
            this.parametricCurvesToolStripMenuItem.Size = new System.Drawing.Size(161, 27);
            this.parametricCurvesToolStripMenuItem.Text = "Parametric Curves";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bresenhamToolStripMenuItem.Text = "Bresenham";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // floodFillRecursiveToolStripMenuItem
            // 
            this.floodFillRecursiveToolStripMenuItem.Name = "floodFillRecursiveToolStripMenuItem";
            this.floodFillRecursiveToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.floodFillRecursiveToolStripMenuItem.Text = "Flood Fill";
            this.floodFillRecursiveToolStripMenuItem.Click += new System.EventHandler(this.floodFillRecursiveToolStripMenuItem_Click);
            // 
            // lineClippingToolStripMenuItem
            // 
            this.lineClippingToolStripMenuItem.Name = "lineClippingToolStripMenuItem";
            this.lineClippingToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.lineClippingToolStripMenuItem.Text = "Line Clipping";
            this.lineClippingToolStripMenuItem.Click += new System.EventHandler(this.lineClippingToolStripMenuItem_Click);
            // 
            // polygonClippingToolStripMenuItem
            // 
            this.polygonClippingToolStripMenuItem.Name = "polygonClippingToolStripMenuItem";
            this.polygonClippingToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.polygonClippingToolStripMenuItem.Text = "Polygon Clipping";
            this.polygonClippingToolStripMenuItem.Click += new System.EventHandler(this.polygonClippingToolStripMenuItem_Click);
            // 
            // bezierToolStripMenuItem
            // 
            this.bezierToolStripMenuItem.Name = "bezierToolStripMenuItem";
            this.bezierToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.bezierToolStripMenuItem.Text = "Bezier and B-Spline";
            this.bezierToolStripMenuItem.Click += new System.EventHandler(this.bezierToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Algorithms.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(902, 553);
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
        private System.Windows.Forms.ToolStripMenuItem rasterizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineRasterizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curveRasterizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionFillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometricClippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametricCurvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillRecursiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineClippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonClippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierToolStripMenuItem;
    }
}
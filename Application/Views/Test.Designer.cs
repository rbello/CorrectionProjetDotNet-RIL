namespace Application.Views
{
    partial class Test
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
            this.panel1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Minimized = false;
            this.panel1.Name = "panel1";
            // 
            // 
            // 
            this.panel1.OrbDropDown.BorderRoundness = 8;
            this.panel1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.panel1.OrbDropDown.Name = "";
            this.panel1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.panel1.OrbDropDown.TabIndex = 0;
            this.panel1.OrbImage = null;
            // 
            // 
            // 
            this.panel1.QuickAcessToolbar.Image = null;
            this.panel1.QuickAcessToolbar.Tag = null;
            this.panel1.QuickAcessToolbar.ToolTipImage = null;
            this.panel1.Size = new System.Drawing.Size(472, 138);
            this.panel1.TabIndex = 0;
            this.panel1.Tabs.Add(this.ribbonTab1);
            this.panel1.TabSpacing = 6;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 353);
            this.Controls.Add(this.panel1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon panel1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
    }
}
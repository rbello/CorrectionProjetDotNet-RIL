using System.Windows.Forms;

namespace Application.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.buttonChooseCustomers = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "Gestion";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.buttonChooseCustomers);
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "Vues ";
            // 
            // buttonChooseCustomers
            // 
            this.buttonChooseCustomers.AltKey = null;
            this.buttonChooseCustomers.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonChooseCustomers.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonChooseCustomers.Image = ((System.Drawing.Image)(resources.GetObject("buttonChooseCustomers.Image")));
            this.buttonChooseCustomers.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonChooseCustomers.SmallImage")));
            this.buttonChooseCustomers.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonChooseCustomers.Tag = null;
            this.buttonChooseCustomers.Text = "Clients";
            this.buttonChooseCustomers.ToolTip = null;
            this.buttonChooseCustomers.ToolTipImage = null;
            this.buttonChooseCustomers.ToolTipTitle = null;
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Tag = null;
            this.ribbonTab2.Text = "Edition";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 600);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon panel1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonButton buttonChooseCustomers;
        private Panel panel2;
    }
}
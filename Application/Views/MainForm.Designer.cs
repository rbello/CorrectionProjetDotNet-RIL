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
            this.TopArea = new System.Windows.Forms.Panel();
            this.RibbonPanel = new System.Windows.Forms.Ribbon();
            this.BottomArea = new System.Windows.Forms.Panel();
            this.CenterArea = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.TopArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopArea
            // 
            this.TopArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopArea.Controls.Add(this.RibbonPanel);
            this.TopArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopArea.Location = new System.Drawing.Point(0, 0);
            this.TopArea.Name = "TopArea";
            this.TopArea.Size = new System.Drawing.Size(1158, 139);
            this.TopArea.TabIndex = 0;
            // 
            // RibbonPanel
            // 
            this.RibbonPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RibbonPanel.Location = new System.Drawing.Point(0, 0);
            this.RibbonPanel.Minimized = false;
            this.RibbonPanel.Name = "RibbonPanel";
            // 
            // 
            // 
            this.RibbonPanel.OrbDropDown.BorderRoundness = 8;
            this.RibbonPanel.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.RibbonPanel.OrbDropDown.Name = "";
            this.RibbonPanel.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.RibbonPanel.OrbDropDown.TabIndex = 0;
            this.RibbonPanel.OrbImage = null;
            // 
            // 
            // 
            this.RibbonPanel.QuickAcessToolbar.Image = null;
            this.RibbonPanel.QuickAcessToolbar.Tag = null;
            this.RibbonPanel.QuickAcessToolbar.ToolTipImage = null;
            this.RibbonPanel.Size = new System.Drawing.Size(1158, 138);
            this.RibbonPanel.TabIndex = 0;
            this.RibbonPanel.TabSpacing = 6;
            // 
            // BottomArea
            // 
            this.BottomArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottomArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomArea.Location = new System.Drawing.Point(0, 579);
            this.BottomArea.Name = "BottomArea";
            this.BottomArea.Size = new System.Drawing.Size(1158, 21);
            this.BottomArea.TabIndex = 1;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Text = "";
            this.InfoLabel.Location = new System.Drawing.Point(5, 5);
            this.BottomArea.Controls.Add(InfoLabel);
            // 
            // CenterArea
            // 
            this.CenterArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterArea.Location = new System.Drawing.Point(0, 120);
            this.CenterArea.Name = "CenterArea";
            this.CenterArea.Size = new System.Drawing.Size(1158, 459);
            this.CenterArea.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1158, 600);
            this.Controls.Add(this.CenterArea);
            this.Controls.Add(this.BottomArea);
            this.Controls.Add(this.TopArea);
            this.Name = "MainForm";
            this.Text = "Gestion Hôtel";
            this.TopArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopArea;
        private Panel BottomArea;
        private Panel CenterArea;
        private Ribbon RibbonPanel;
        private Label InfoLabel;
    }
}
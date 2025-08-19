namespace RStarReplayer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CheckRuleButton = new Button();
            SavingON = new Button();
            SavingOFF = new Button();
            WhatModeLabel = new Label();
            VersionNumberLabel = new Label();
            SuspendLayout();
            // 
            // CheckRuleButton
            // 
            CheckRuleButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckRuleButton.Location = new Point(436, 298);
            CheckRuleButton.Margin = new Padding(3, 2, 3, 2);
            CheckRuleButton.Name = "CheckRuleButton";
            CheckRuleButton.Size = new Size(165, 39);
            CheckRuleButton.TabIndex = 1;
            CheckRuleButton.Text = "Manual Rule Check";
            CheckRuleButton.UseVisualStyleBackColor = true;
            CheckRuleButton.Click += CheckRuleButton_Click;
            // 
            // SavingON
            // 
            SavingON.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SavingON.Location = new Point(10, 296);
            SavingON.Margin = new Padding(3, 2, 3, 2);
            SavingON.Name = "SavingON";
            SavingON.Size = new Size(157, 39);
            SavingON.TabIndex = 2;
            SavingON.Text = "No Saving ON";
            SavingON.UseVisualStyleBackColor = true;
            SavingON.Click += SavingON_Click;
            // 
            // SavingOFF
            // 
            SavingOFF.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SavingOFF.Location = new Point(172, 296);
            SavingOFF.Margin = new Padding(3, 2, 3, 2);
            SavingOFF.Name = "SavingOFF";
            SavingOFF.Size = new Size(157, 39);
            SavingOFF.TabIndex = 3;
            SavingOFF.Text = "No Saving OFF";
            SavingOFF.UseVisualStyleBackColor = true;
            SavingOFF.Click += SavingOFF_Click;
            // 
            // WhatModeLabel
            // 
            WhatModeLabel.AutoSize = true;
            WhatModeLabel.BackColor = Color.Transparent;
            WhatModeLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WhatModeLabel.ForeColor = Color.IndianRed;
            WhatModeLabel.Location = new Point(10, 9);
            WhatModeLabel.Name = "WhatModeLabel";
            WhatModeLabel.Size = new Size(184, 37);
            WhatModeLabel.TabIndex = 4;
            WhatModeLabel.Text = "No Mode Yet";
            WhatModeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // VersionNumberLabel
            // 
            VersionNumberLabel.AutoSize = true;
            VersionNumberLabel.BackColor = Color.Transparent;
            VersionNumberLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VersionNumberLabel.ForeColor = Color.White;
            VersionNumberLabel.Location = new Point(446, 9);
            VersionNumberLabel.Name = "VersionNumberLabel";
            VersionNumberLabel.Size = new Size(155, 20);
            VersionNumberLabel.TabIndex = 5;
            VersionNumberLabel.Text = "RStarReplayer v1.0.1";
            VersionNumberLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(612, 346);
            Controls.Add(VersionNumberLabel);
            Controls.Add(WhatModeLabel);
            Controls.Add(SavingOFF);
            Controls.Add(SavingON);
            Controls.Add(CheckRuleButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "RStarReplayer";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CheckRuleButton;
        private Button SavingON;
        private Button SavingOFF;
        private Label WhatModeLabel;
        private Label VersionNumberLabel;
    }
}

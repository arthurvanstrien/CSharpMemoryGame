﻿namespace MemoryGame
{
    partial class StartupScreen
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
            this.HostGameButton = new System.Windows.Forms.Button();
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.IPField = new System.Windows.Forms.TextBox();
            this.PortField = new System.Windows.Forms.TextBox();
            this.IpAndPortDivider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HostGameButton
            // 
            this.HostGameButton.Location = new System.Drawing.Point(13, 13);
            this.HostGameButton.Name = "HostGameButton";
            this.HostGameButton.Size = new System.Drawing.Size(142, 33);
            this.HostGameButton.TabIndex = 0;
            this.HostGameButton.Text = "Host Game";
            this.HostGameButton.UseVisualStyleBackColor = true;
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.Location = new System.Drawing.Point(13, 82);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(147, 33);
            this.JoinGameButton.TabIndex = 1;
            this.JoinGameButton.Text = "Join Game";
            this.JoinGameButton.UseVisualStyleBackColor = true;
            // 
            // IPField
            // 
            this.IPField.Location = new System.Drawing.Point(197, 82);
            this.IPField.Name = "IPField";
            this.IPField.Size = new System.Drawing.Size(287, 29);
            this.IPField.TabIndex = 2;
            // 
            // PortField
            // 
            this.PortField.Location = new System.Drawing.Point(515, 82);
            this.PortField.Name = "PortField";
            this.PortField.Size = new System.Drawing.Size(100, 29);
            this.PortField.TabIndex = 3;
            // 
            // IpAndPortDivider
            // 
            this.IpAndPortDivider.AutoSize = true;
            this.IpAndPortDivider.Location = new System.Drawing.Point(491, 82);
            this.IpAndPortDivider.Name = "IpAndPortDivider";
            this.IpAndPortDivider.Size = new System.Drawing.Size(18, 25);
            this.IpAndPortDivider.TabIndex = 4;
            this.IpAndPortDivider.Text = ":";
            // 
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 726);
            this.Controls.Add(this.IpAndPortDivider);
            this.Controls.Add(this.PortField);
            this.Controls.Add(this.IPField);
            this.Controls.Add(this.JoinGameButton);
            this.Controls.Add(this.HostGameButton);
            this.Name = "StartupScreen";
            this.Text = "StartupScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HostGameButton;
        private System.Windows.Forms.Button JoinGameButton;
        private System.Windows.Forms.TextBox IPField;
        private System.Windows.Forms.TextBox PortField;
        private System.Windows.Forms.Label IpAndPortDivider;
    }
}
namespace MemoryGame
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
            this.RulesBox = new System.Windows.Forms.TextBox();
            this.PlayerNameBox = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HostGameButton
            // 
            this.HostGameButton.Location = new System.Drawing.Point(12, 58);
            this.HostGameButton.Name = "HostGameButton";
            this.HostGameButton.Size = new System.Drawing.Size(147, 43);
            this.HostGameButton.TabIndex = 0;
            this.HostGameButton.Text = "Host Game";
            this.HostGameButton.UseVisualStyleBackColor = true;
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.Location = new System.Drawing.Point(12, 122);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(147, 38);
            this.JoinGameButton.TabIndex = 1;
            this.JoinGameButton.Text = "Join Game";
            this.JoinGameButton.UseVisualStyleBackColor = true;
            // 
            // IPField
            // 
            this.IPField.Location = new System.Drawing.Point(191, 126);
            this.IPField.Name = "IPField";
            this.IPField.Size = new System.Drawing.Size(417, 29);
            this.IPField.TabIndex = 2;
            // 
            // RulesBox
            // 
            this.RulesBox.Location = new System.Drawing.Point(12, 195);
            this.RulesBox.Multiline = true;
            this.RulesBox.Name = "RulesBox";
            this.RulesBox.Size = new System.Drawing.Size(865, 507);
            this.RulesBox.TabIndex = 6;
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.Location = new System.Drawing.Point(13, 13);
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(595, 29);
            this.PlayerNameBox.TabIndex = 7;
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Location = new System.Drawing.Point(196, 67);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(19, 25);
            this.MessageBox.TabIndex = 8;
            this.MessageBox.Text = "-";
            // 
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 726);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.PlayerNameBox);
            this.Controls.Add(this.RulesBox);
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
        private System.Windows.Forms.TextBox RulesBox;
        private System.Windows.Forms.TextBox PlayerNameBox;
        private System.Windows.Forms.Label MessageBox;
    }
}
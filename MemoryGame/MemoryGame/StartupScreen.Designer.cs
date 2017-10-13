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
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 726);
            this.Controls.Add(this.HostGameButton);
            this.Name = "StartupScreen";
            this.Text = "StartupScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HostGameButton;
    }
}
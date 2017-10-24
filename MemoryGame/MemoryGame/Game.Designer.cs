namespace MemoryGame
{
    partial class Game
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
            this.Player1LB = new System.Windows.Forms.Label();
            this.Player2LB = new System.Windows.Forms.Label();
            this.Score1LB = new System.Windows.Forms.Label();
            this.Score2LB = new System.Windows.Forms.Label();
            this.MemoryGrid = new System.Windows.Forms.TableLayoutPanel();
            this.Player1PN = new System.Windows.Forms.Panel();
            this.Player2PN = new System.Windows.Forms.Panel();
            this.Player1PN.SuspendLayout();
            this.Player2PN.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1LB
            // 
            this.Player1LB.AutoSize = true;
            this.Player1LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Player1LB.Location = new System.Drawing.Point(3, 10);
            this.Player1LB.Name = "Player1LB";
            this.Player1LB.Size = new System.Drawing.Size(92, 26);
            this.Player1LB.TabIndex = 0;
            this.Player1LB.Text = "Player 1";
            // 
            // Player2LB
            // 
            this.Player2LB.AutoSize = true;
            this.Player2LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Player2LB.Location = new System.Drawing.Point(5, 10);
            this.Player2LB.Name = "Player2LB";
            this.Player2LB.Size = new System.Drawing.Size(92, 26);
            this.Player2LB.TabIndex = 1;
            this.Player2LB.Text = "Player 1";
            // 
            // Score1LB
            // 
            this.Score1LB.AutoSize = true;
            this.Score1LB.Location = new System.Drawing.Point(12, 47);
            this.Score1LB.Name = "Score1LB";
            this.Score1LB.Size = new System.Drawing.Size(47, 13);
            this.Score1LB.TabIndex = 2;
            this.Score1LB.Text = "Score: 0";
            // 
            // Score2LB
            // 
            this.Score2LB.AutoSize = true;
            this.Score2LB.Location = new System.Drawing.Point(23, 55);
            this.Score2LB.Name = "Score2LB";
            this.Score2LB.Size = new System.Drawing.Size(47, 13);
            this.Score2LB.TabIndex = 3;
            this.Score2LB.Text = "Score: 0";
            // 
            // MemoryGrid
            // 
            this.MemoryGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.MemoryGrid.Location = new System.Drawing.Point(110, 12);
            this.MemoryGrid.Name = "MemoryGrid";
            this.MemoryGrid.Size = new System.Drawing.Size(592, 495);
            this.MemoryGrid.TabIndex = 4;
            // 
            // Player1PN
            // 
            this.Player1PN.Controls.Add(this.Score1LB);
            this.Player1PN.Controls.Add(this.Player1LB);
            this.Player1PN.Location = new System.Drawing.Point(0, -1);
            this.Player1PN.Name = "Player1PN";
            this.Player1PN.Size = new System.Drawing.Size(110, 520);
            this.Player1PN.TabIndex = 6;
            // 
            // Player2PN
            // 
            this.Player2PN.Controls.Add(this.Player2LB);
            this.Player2PN.Controls.Add(this.Score2LB);
            this.Player2PN.Location = new System.Drawing.Point(702, -1);
            this.Player2PN.Name = "Player2PN";
            this.Player2PN.Size = new System.Drawing.Size(110, 520);
            this.Player2PN.TabIndex = 7;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 519);
            this.Controls.Add(this.Player2PN);
            this.Controls.Add(this.Player1PN);
            this.Controls.Add(this.MemoryGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "Memory";
            this.Player1PN.ResumeLayout(false);
            this.Player1PN.PerformLayout();
            this.Player2PN.ResumeLayout(false);
            this.Player2PN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Player1LB;
        private System.Windows.Forms.Label Player2LB;
        private System.Windows.Forms.Label Score1LB;
        private System.Windows.Forms.Label Score2LB;
        private System.Windows.Forms.TableLayoutPanel MemoryGrid;
        private System.Windows.Forms.Panel Player1PN;
        private System.Windows.Forms.Panel Player2PN;
    }
}


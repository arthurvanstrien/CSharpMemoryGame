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
            this.CellSizeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player1LB
            // 
            this.Player1LB.AutoSize = true;
            this.Player1LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Player1LB.Location = new System.Drawing.Point(12, 9);
            this.Player1LB.Name = "Player1LB";
            this.Player1LB.Size = new System.Drawing.Size(92, 26);
            this.Player1LB.TabIndex = 0;
            this.Player1LB.Text = "Player 1";
            // 
            // Player2LB
            // 
            this.Player2LB.AutoSize = true;
            this.Player2LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Player2LB.Location = new System.Drawing.Point(707, 9);
            this.Player2LB.Name = "Player2LB";
            this.Player2LB.Size = new System.Drawing.Size(92, 26);
            this.Player2LB.TabIndex = 1;
            this.Player2LB.Text = "Player 1";
            // 
            // Score1LB
            // 
            this.Score1LB.AutoSize = true;
            this.Score1LB.Location = new System.Drawing.Point(12, 46);
            this.Score1LB.Name = "Score1LB";
            this.Score1LB.Size = new System.Drawing.Size(47, 13);
            this.Score1LB.TabIndex = 2;
            this.Score1LB.Text = "Score: 0";
            // 
            // Score2LB
            // 
            this.Score2LB.AutoSize = true;
            this.Score2LB.Location = new System.Drawing.Point(752, 46);
            this.Score2LB.Name = "Score2LB";
            this.Score2LB.Size = new System.Drawing.Size(47, 13);
            this.Score2LB.TabIndex = 3;
            this.Score2LB.Text = "Score: 0";
            // 
            // MemoryGrid
            // 
            this.MemoryGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MemoryGrid.Location = new System.Drawing.Point(110, 12);
            this.MemoryGrid.Name = "MemoryGrid";
            this.MemoryGrid.Size = new System.Drawing.Size(591, 495);
            this.MemoryGrid.TabIndex = 4;
            // 
            // CellSizeLB
            // 
            this.CellSizeLB.AutoSize = true;
            this.CellSizeLB.Location = new System.Drawing.Point(30, 418);
            this.CellSizeLB.Name = "CellSizeLB";
            this.CellSizeLB.Size = new System.Drawing.Size(29, 13);
            this.CellSizeLB.TabIndex = 5;
            this.CellSizeLB.Text = "hallo";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 519);
            this.Controls.Add(this.CellSizeLB);
            this.Controls.Add(this.MemoryGrid);
            this.Controls.Add(this.Score2LB);
            this.Controls.Add(this.Score1LB);
            this.Controls.Add(this.Player2LB);
            this.Controls.Add(this.Player1LB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player1LB;
        private System.Windows.Forms.Label Player2LB;
        private System.Windows.Forms.Label Score1LB;
        private System.Windows.Forms.Label Score2LB;
        private System.Windows.Forms.TableLayoutPanel MemoryGrid;
        private System.Windows.Forms.Label CellSizeLB;
    }
}


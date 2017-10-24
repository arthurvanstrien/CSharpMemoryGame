using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Game : Form
    {
        StreamReader streamReader;
        StreamWriter streamWriter;
        Boolean MyTurn;
        float x;
        float y;
        int player1Score = 0;
        int player2Score = 0;
        Point firstCell, secondCell, flipCheck;
        List<string> Images;

        public Game(string p1, string p2, int columns, int rows, List<string> Images, Boolean heads, StreamReader streamReader, StreamWriter streamWriter)
        {
            MyTurn = heads;
            this.streamReader = streamReader;
            this.streamWriter = streamWriter;
            this.Images = Images;
            x = columns;
            y = rows;
            flipCheck = new Point(10, 10);
            firstCell = flipCheck;
            secondCell = flipCheck;
            InitializeComponent();
            MemoryGrid.Controls.Clear();
            MemoryGrid.ColumnCount = (int)y;
            MemoryGrid.RowCount = (int) x;
            Player1LB.Text = p1;
            Player2LB.Text = p2;

            for (int i = 0; i <= x; i++)
            {
                RowStyle style = new RowStyle();
                MemoryGrid.RowStyles.Add(style);
            }

            for (int i = 0; i < y; i++)
            {
                ColumnStyle style = new ColumnStyle();
                MemoryGrid.ColumnStyles.Add(style);
            }

            foreach (RowStyle style in MemoryGrid.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = MemoryGrid.Height / x;
            }
            foreach (ColumnStyle style in MemoryGrid.ColumnStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Width = MemoryGrid.Width / y;
            }

            Random rand = new Random();
            Padding p = new Padding(2,2,2,2);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Label newLabel = new Label();
                    newLabel.Text = "";
                    newLabel.BackColor = Color.FromArgb(rand.Next(50, 255), rand.Next(50, 255), rand.Next(50, 255));
                    newLabel.Dock = DockStyle.Fill;
                    newLabel.Margin = p;
                    MemoryGrid.Controls.Add(newLabel, j, i);
                    newLabel.MouseClick += new MouseEventHandler(OnClick);
                }
            }

            //Make the thread that listens to the input from the otherside.
            Thread thread = new Thread(Reader);
            thread.Start();

            Show();
        }

        public void OnClick(object sender, MouseEventArgs e)
        {
            TableLayoutPanelCellPosition pos = MemoryGrid.GetCellPosition((Label)sender);
            Point CellClicked = new Point(MemoryGrid.GetColumn((Label)sender), MemoryGrid.GetRow((Label)sender));
            int width = MemoryGrid.GetColumnWidths()[pos.Column];
            int height = MemoryGrid.GetRowHeights()[pos.Row];

            CellSizeLB.Text = "myTurn: " + MyTurn;

            if (MyTurn)
            {
                LabelClicked(CellClicked);
                string message = (CellClicked.Y * (int) y + CellClicked.X).ToString();
                streamWriter.WriteLine(message);
                streamWriter.Flush();
            }
        }

        private void LabelClicked(Point CellClicked) {
            if (firstCell == flipCheck)
            {
                CardFlip(CellClicked);
                firstCell = CellClicked;
            }
            else if (secondCell == flipCheck && firstCell != CellClicked)
            {
                CardFlip(CellClicked);
                secondCell = CellClicked;
                CellCheck();
            }
            else if (firstCell == CellClicked || secondCell == CellClicked)
            {
                CardFlip(CellClicked);
            }
            // send data

            if (EndTurnCheck())
            {
                EndTurn();
                firstCell = flipCheck;
                secondCell = flipCheck;
            }

        }

        private void CardFlip(Point CellClicked) {
            Label newLabel = (Label)MemoryGrid.GetControlFromPosition(CellClicked.X, CellClicked.Y);
            if (newLabel.Text == "")
            {
                Image newImage = Image.FromFile(Images[(int)(CellClicked.Y * y + CellClicked.X)]);
                newLabel.Image = newImage;
                newLabel.Text = " ";
            }
            else
            {
                newLabel.Image = null;
                newLabel.Text = "";
            }
            this.Refresh();
        }

        public void CellCheck() {
            Label firstLabel = (Label)MemoryGrid.GetControlFromPosition(firstCell.X, firstCell.Y);
            Label secondLabel = (Label)MemoryGrid.GetControlFromPosition(secondCell.X, secondCell.Y);
            if (Images[(int)(firstCell.Y * y + firstCell.X)] == Images[(int)(secondCell.Y * y + secondCell.X)]) {
                if (MyTurn) {
                    player1Score++;
                    Score1LB.Text = "score: " + player1Score.ToString();
                }else
                {
                    player2Score++;
                    Score2LB.Text = "score: " + player2Score.ToString();
                }
                GrayOut();
                EndTurn();
            }
        }
        private Boolean EndTurnCheck() {
            Label firstLabel = (Label)MemoryGrid.GetControlFromPosition(firstCell.X, firstCell.Y);
            Label secondLabel = (Label)MemoryGrid.GetControlFromPosition(secondCell.X, secondCell.Y);
            if (firstLabel.Text == "" && secondLabel?.Text == "") {
                return true;
            }
            return false;
        }

        private void EndTurn() {
            MyTurn = !MyTurn;
        }

        private void GrayOut() {
            Label firstLabel = (Label)MemoryGrid.GetControlFromPosition(firstCell.X, firstCell.Y);
            Label secondLabel = (Label)MemoryGrid.GetControlFromPosition(secondCell.X, secondCell.Y);

            Bitmap colouredImage = new Bitmap(firstLabel.Image);
                Bitmap grayImage = new Bitmap(colouredImage.Width, colouredImage.Height);

            for (int i = 0; i < colouredImage.Width; i++)
            {
                for (int x = 0; x < colouredImage.Height; x++)
                {
                    Color oc = colouredImage.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    grayImage.SetPixel(i, x, nc);
                }
            }
            firstLabel.Image = grayImage;
            secondLabel.Image = grayImage;
            firstLabel.BackColor = Color.Gray;
            secondLabel.BackColor = Color.Gray;
        }

        private void Reader()
        {
            while (true)
            {
                string line = streamReader.ReadLine();
                int card = int.Parse(line);
                UpdateLabelClicked(new Point(card % ((int)x), card / ((int)y)));
            }
        }

        private void UpdateLabelClicked(Point point)
        {
            Invoke(new Action(() =>
            {
                LabelClicked(point);
            }));
        }
    }
}

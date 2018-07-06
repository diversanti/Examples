using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Refresh();
            if (inputTextBox.Text.Equals("") || inputTextBox.Text == null)
                return;
            startingPoint.X = 10;
            startingPoint.Y = this.Height - 10;
            int rectsAmount = int.Parse(inputTextBox.Text);
            rectWidth = (this.Width - rectSpace * (rectsAmount + 1)) / rectsAmount;
            for (int i = 0; i < rectsAmount; i++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(10,200), rnd.Next(10,200), rnd.Next(30,200));
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(randomColor);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                Rectangle rect = new Rectangle();
                int rectHeight = rnd.Next(35, maxHeight);
                rect.Location = new Point(startingPoint.X + i * (rectWidth + rectSpace), startingPoint.Y - rectHeight);
                rect.Size = new Size(rectWidth, rectHeight);
                formGraphics.FillRectangle(myBrush, rect);
                myBrush.Dispose();
                formGraphics.Dispose();
            }
        }
    }
}


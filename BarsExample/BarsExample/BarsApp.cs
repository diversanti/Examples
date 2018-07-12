using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarsExample
{
    public partial class BarsApp : Form
    {
        public BarsApp()
        {
            InitializeComponent();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                rects.Clear();
                this.Refresh();
                startingPoint.X = 10;
                startingPoint.Y = this.Height - 10;
                int rectsAmount = int.Parse(inputTextBox.Text);
                rectWidth = (this.Width - rectSpace * (rectsAmount + 1)) / rectsAmount;
                for (int i = 0; i < rectsAmount; i++)
                {
                    DrawRects(10, this.Height - 10, i);
                }
                SleepTimer.Enabled = true;
                SleepTimer.Interval = int.Parse(IntervalBox.Text);
                SleepTimer.Start();
            }
        }

        private void changeRects(int rectsAmount)
        {
            int firstRect = -1;
            int secondRect = -1;
            while (firstRect == secondRect)
            {
                firstRect = rnd.Next(0, rectsAmount);
                secondRect = rnd.Next(0, rectsAmount);
            }
            if (rects[firstRect].GetRect().Height < rects[secondRect].GetRect().Height)
            {
                var tmp = rects[firstRect];
                rects[firstRect] = rects[secondRect];
                rects[secondRect] = tmp;
                DeleteOldAndDrawNew(rects);
            }
        }

        private void DeleteOldAndDrawNew(List<MyRect> rects)
        {
            this.Refresh();
            for (int i = 0; i < rects.Count; i++)
            {
                Color color = rects[i].GetColor();
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(color);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                Rectangle rect = new Rectangle();
                rect.Location = new Point(startingPoint.X + i * (rectWidth + rectSpace), startingPoint.Y - rects[i].GetRect().Height);
                rect.Size = new Size(rectWidth, rects[i].GetRect().Height);
                formGraphics.FillRectangle(myBrush, rect);
                myBrush.Dispose();
                formGraphics.Dispose();
            }
        }

        private bool validate()
        {
            SleepTimer.Stop();
            string message = "Your Input Is Not Number";
            string caption;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (!int.TryParse(inputTextBox.Text, out int n) || int.Parse(inputTextBox.Text) <= 0 || !int.TryParse(IntervalBox.Text, out int m) || int.Parse(IntervalBox.Text) <= 0)
            {
                caption = "Error Detected in Input";
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Refresh();
                    return false;
                }
            }

            if (int.Parse(inputTextBox.Text) > 70)
            {
                caption = "Your Number Is Too Big";
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Refresh();
                    return false;
                }
            }
            return true;
        }

        private void DrawRects(int startingPointX, int StartingPointY, int drawnRectsCount)
        {
            Color randomColor = Color.FromArgb(rnd.Next(10, 200), rnd.Next(10, 200), rnd.Next(30, 200));
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(randomColor);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            Rectangle rect = new Rectangle();
            int rectHeight = rnd.Next(35, maxHeight);
            rect.Location = new Point(startingPoint.X + drawnRectsCount * (rectWidth + rectSpace), startingPoint.Y - rectHeight);
            rect.Size = new Size(rectWidth, rectHeight);
            rects.Add(new MyRect(rect, randomColor));
            formGraphics.FillRectangle(myBrush, rect);
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void SleepTimer_Tick(object sender, EventArgs e)
        {
            int rectsAmount = int.Parse(inputTextBox.Text);
            changeRects(rectsAmount);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            SleepTimer.Stop();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SleepTimer.Enabled)
            {
                SleepTimer.Stop();
            }
        }

        private void IntervalBox_TextChanged(object sender, EventArgs e)
        {
            if (SleepTimer.Enabled)
            {
                SleepTimer.Stop();
            }
        }
    }

    class MyRect
    {
        private Rectangle rect;
        private Color color;
        public MyRect(Rectangle rect, Color color)
        {
            this.rect = rect;
            this.color = color;
        }

        public Rectangle GetRect()
        {
            return this.rect;
        }

        public Color GetColor()
        {
            return this.color;
        }
    }
}




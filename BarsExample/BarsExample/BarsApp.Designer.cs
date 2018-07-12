using System;
using System.Collections.Generic;
using System.Drawing;

namespace BarsExample
{
    partial class BarsApp
    {
        private List<MyRect> rects = new List<MyRect>();
        private Random rnd = new Random();
        private int rectSpace = 10;
        private int maxHeight = 400;
        private int rectWidth = 0;
        private Point startingPoint = new Point();
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
            this.components = new System.ComponentModel.Container();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.IntervalBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SleepTimer = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(184, 20);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(75, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(301, 22);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(63, 13);
            this.IntervalLabel.TabIndex = 1;
            this.IntervalLabel.Text = "interval(ms):";
            // 
            // IntervalBox
            // 
            this.IntervalBox.Location = new System.Drawing.Point(382, 19);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(69, 20);
            this.IntervalBox.TabIndex = 2;
            this.IntervalBox.TextChanged += new System.EventHandler(this.IntervalBox_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(468, 17);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SleepTimer
            // 
            this.SleepTimer.Tick += new System.EventHandler(this.SleepTimer_Tick);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(559, 17);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // BarsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "BarsApp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TextBox IntervalBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer SleepTimer;
        private System.Windows.Forms.Button StopButton;
    }
}


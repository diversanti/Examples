namespace TranslatorApp
{
    partial class TranslatorVisual
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
            this.Translate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TranslatedText = new System.Windows.Forms.TextBox();
            this.enteredText = new System.Windows.Forms.TextBox();
            this.pigLatin = new System.Windows.Forms.RadioButton();
            this.pigGreek = new System.Windows.Forms.RadioButton();
            this.TranslatedTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(12, 415);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(75, 23);
            this.Translate.TabIndex = 0;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(109, 415);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter English text here:";
            // 
            // TranslatedText
            // 
            this.TranslatedText.Location = new System.Drawing.Point(12, 236);
            this.TranslatedText.Multiline = true;
            this.TranslatedText.Name = "TranslatedText";
            this.TranslatedText.Size = new System.Drawing.Size(776, 160);
            this.TranslatedText.TabIndex = 4;
            // 
            // enteredText
            // 
            this.enteredText.Location = new System.Drawing.Point(12, 34);
            this.enteredText.Multiline = true;
            this.enteredText.Name = "enteredText";
            this.enteredText.Size = new System.Drawing.Size(778, 110);
            this.enteredText.TabIndex = 5;
            // 
            // pigLatin
            // 
            this.pigLatin.AutoSize = true;
            this.pigLatin.Location = new System.Drawing.Point(15, 167);
            this.pigLatin.Name = "pigLatin";
            this.pigLatin.Size = new System.Drawing.Size(66, 17);
            this.pigLatin.TabIndex = 7;
            this.pigLatin.TabStop = true;
            this.pigLatin.Text = "Pig Latin";
            this.pigLatin.UseVisualStyleBackColor = true;
            this.pigLatin.CheckedChanged += new System.EventHandler(this.pigLatin_CheckedChanged);
            // 
            // pigGreek
            // 
            this.pigGreek.AutoSize = true;
            this.pigGreek.Location = new System.Drawing.Point(146, 167);
            this.pigGreek.Name = "pigGreek";
            this.pigGreek.Size = new System.Drawing.Size(72, 17);
            this.pigGreek.TabIndex = 8;
            this.pigGreek.TabStop = true;
            this.pigGreek.Text = "Pig Greek";
            this.pigGreek.UseVisualStyleBackColor = true;
            this.pigGreek.CheckedChanged += new System.EventHandler(this.pigGreek_CheckedChanged);
            // 
            // TranslatedTo
            // 
            this.TranslatedTo.AutoSize = true;
            this.TranslatedTo.Location = new System.Drawing.Point(12, 204);
            this.TranslatedTo.Name = "TranslatedTo";
            this.TranslatedTo.Size = new System.Drawing.Size(102, 13);
            this.TranslatedTo.TabIndex = 9;
            this.TranslatedTo.Text = "Pig Latin translation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.TranslatedTo);
            this.Controls.Add(this.pigGreek);
            this.Controls.Add(this.pigLatin);
            this.Controls.Add(this.enteredText);
            this.Controls.Add(this.TranslatedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Translate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TranslatedText;
        private System.Windows.Forms.TextBox enteredText;
        private System.Windows.Forms.RadioButton pigLatin;
        private System.Windows.Forms.RadioButton pigGreek;
        private System.Windows.Forms.Label TranslatedTo;
    }
}


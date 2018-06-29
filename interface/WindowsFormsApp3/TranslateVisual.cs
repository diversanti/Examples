using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslatorApp
{
    public partial class TranslatorVisual : Form
    {
        public TranslatorVisual()
        {
            InitializeComponent();
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            String text = enteredText.Text;
            ITranslator translator = null;
            if (pigGreek.Checked)
            {
                translator = new GreekTranslator();
               
            }
            if (pigLatin.Checked)
            {
                translator = new LatinTranslator();
                
            }
            TranslatedText.Text = translator.Translate(text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TranslatedText.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pigLatin_CheckedChanged(object sender, EventArgs e)
        {
            TranslatedTo.Text = "Pig Latin Translation:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pigLatin.Select();
        }

        private void pigGreek_CheckedChanged(object sender, EventArgs e)
        {
            TranslatedTo.Text = "Pig Greek Translation:";
        }
    }
}

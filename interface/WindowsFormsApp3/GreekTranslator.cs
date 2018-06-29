﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorApp
{
    public class GreekTranslator : ITranslator
    {
        public string Translate(String text)
        {
            String result = "";
            string[] words = text.Split(' ');
            foreach (String word in words)
            {
                if (word.Equals(""))
                {
                    break;
                }
                if (IsVowel(word[0]))
                {
                    result += word + "oi ";
                }
                else
                {
                    result += word + "omatos ";
                }
            }
            return result;
        }

        private bool IsVowel(char letter)
        {
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}

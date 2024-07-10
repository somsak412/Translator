using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateASPMVC.Models
{
    public class Translator
    {
        public string OriginalText { get; set; }
        public string TranslatedText { get; private set; }
        
        public void Translate()
        {
            if (string.IsNullOrEmpty(OriginalText))
            {
                TranslatedText = "UBCO ";
                return;
            }

            string vowels = "aeiouAEIOU";
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            char NextConsonant(char c)
            {
                int index = consonants.IndexOf(c);
                if (index == -1)
                    return c; // not a consonant

                return consonants[(index + 1) % consonants.Length];
            }

            var translatedBuilder = new System.Text.StringBuilder("UBCO ");

            foreach (char c in OriginalText)
            {
                if (vowels.Contains(c))
                {
                    translatedBuilder.Append(c).Append(c);
                }
                else if (char.IsLetter(c))
                {
                    translatedBuilder.Append(NextConsonant(c));
                }
                else
                {
                    translatedBuilder.Append(c);
                }
            }

            int wordCount = OriginalText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            translatedBuilder.Append(wordCount);

            TranslatedText = translatedBuilder.ToString();
        }
    }

}

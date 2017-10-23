using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R28.ReplaceTypeCodeWithClass.depois
{
    class Teste
    {
        public Teste()
        {
            var word1 = new Word("Este", FontStyle.Normal);
            var word2 = new Word("é", FontStyle.Normal);
            var word3 = new Word("um", FontStyle.Normal);
            var word4 = new Word("pequeno", FontStyle.Italic);
            var word5 = new Word("teste", FontStyle.Bold);
        }
    }

    class Word
    {
        public string Text { get; private set; }
        public FontStyle FontStyle { get; private set; }

        public Word(string text, int styleCode)
        {
            Text = text;
            FontStyle = new FontStyle(styleCode);
        }
    }

    class FontStyle
    {
        public static int Normal = 0;
        public static int Italic = 1;
        public static int Bold = 2;
        public static int BoldItalic = 3;

        public int StyleCode { get; private set; }

        public FontStyle(int styleCode)
        {
            this.StyleCode = styleCode;
        }
    }
}

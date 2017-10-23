using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R28.ReplaceTypeCodeWithClass.antes
{
    class Word
    {
        public static int Normal = 0;
        public static int Italic = 1;
        public static int Bold = 2;
        public static int BoldItalic = 3;

        public string Text { get; private set; }
        public int FontStyle { get; private set; }

        public Word(string text, int fontStyle)
        {
            Text = text;
            FontStyle = fontStyle;
        }
    }
}

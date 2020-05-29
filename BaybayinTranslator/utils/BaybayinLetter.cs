using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BaybayinTranslator.utils
{
    public class BaybayinLetter
    {

        public string letter { get; private set; }
        public Rectangle postion { get; private set; }
        public Vowels vowel { get; private set; }
 

        public BaybayinLetter(String letter, int x, int y, int w, int h)
        {
            this.letter = letter;
            this.postion = new Rectangle(x, y, w, h);
            this.vowel = Vowels.EI;
        }


        public BaybayinLetter(String letter, int x, int y, int w, int h, Vowels v)
        {
            this.letter = letter;
            this.postion = new Rectangle(x, y, w, h);
            this.vowel = v;
        }


    }

    public enum Vowels
    {
        NONE, EI, OU
    }
}

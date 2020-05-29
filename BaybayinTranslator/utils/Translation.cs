using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaybayinTranslator.utils
{
    class Translation
    {
        public string name { get; private set; }
        public BaybayinLetter[] letters { get; private set; }

        public Translation(string name, BaybayinLetter[] letters)
        {
            this.name = name;
            this.letters = letters;
        }

        public override string ToString()
        {
            return name;
        }

        public BaybayinLetter getBaybayinLetter(string letter)
        {
            foreach( BaybayinLetter bl in letters)
                if(bl.letter.ToLower().Equals(letter.ToLower()))
                    return bl;

            return null;
        }
    }
}

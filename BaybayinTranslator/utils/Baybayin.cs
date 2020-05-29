using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaybayinTranslator.utils
{
    class Baybayin
    {
        //public static string[] Translations = new string[]{
        //    "Tagalog Doctrina",
        //    "Baybayin Lopez",
        //    "Bikol Mintz",
        //    "Tagalog Stylized",
        //    "Kabena'O",
        //    "Bagoyin",
        //    "Nordenx",
        //    "FMB"
        //};

        public List<Translation> translations;
        public Translation SelectedTranslation { get; private set; }

        public Baybayin()
        {
            translations = new List<Translation>();


            Translation t1 = new Translation("Tagalog Doctrina", new BaybayinLetter[]{
                new BaybayinLetter("A", 106, 119, 37, 30),
                new BaybayinLetter("E",106, 169, 37, 30),
                new BaybayinLetter("I",106, 169, 37, 30),
                new BaybayinLetter("O",106, 219, 37, 30),
                new BaybayinLetter("U",106, 219, 37, 30),
                new BaybayinLetter("B",106, 269, 37, 30),
                new BaybayinLetter("K",106, 319, 37, 30),
                new BaybayinLetter("D",106, 369, 37, 30),
                new BaybayinLetter("G",106, 419, 37, 30),
                new BaybayinLetter("H",106, 469, 37, 30),
                new BaybayinLetter("L",106, 516, 37, 36),
                new BaybayinLetter("M",106, 569, 37, 30),
                new BaybayinLetter("N",106, 619, 37, 30),
                new BaybayinLetter("Ng",106, 669, 37, 30),
                new BaybayinLetter("P",106, 719, 37, 30),
                new BaybayinLetter("R",106, 769, 37, 30),
                new BaybayinLetter("S",106, 819, 37, 30),
                new BaybayinLetter("T",106, 869, 37, 30),
                new BaybayinLetter("W",106, 919, 37, 30),
                new BaybayinLetter("Y",106, 969, 37, 30),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });

            Translation t2 = new Translation("Baybayin Lopez", new BaybayinLetter[]{
                new BaybayinLetter("A", 215, 118, 46, 32),
                new BaybayinLetter("E",215, 168, 46, 32),
                new BaybayinLetter("I",215, 168, 46, 32),
                new BaybayinLetter("O",215, 218, 46, 32),
                new BaybayinLetter("U",215, 218, 46, 32),
                new BaybayinLetter("B",215, 268, 46, 32),
                new BaybayinLetter("K",215, 318, 46, 32),
                new BaybayinLetter("D",215, 368, 46, 32),
                new BaybayinLetter("G",215, 418, 46, 32),
                new BaybayinLetter("H",215, 468, 46, 32),
                new BaybayinLetter("L",215, 518, 46, 32),
                new BaybayinLetter("M",215, 568, 46, 32),
                new BaybayinLetter("N",215, 618, 46, 32),
                new BaybayinLetter("Ng",215, 668, 46, 32),
                new BaybayinLetter("P",215, 718, 46, 32),
                new BaybayinLetter("R",215, 768, 46, 32),
                new BaybayinLetter("S",215, 818, 46, 32),
                new BaybayinLetter("T",215, 868, 46, 32),
                new BaybayinLetter("W",215, 918, 46, 32),
                new BaybayinLetter("Y",215, 968, 46, 32),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });


            Translation t3 = new Translation("Bikol Mintz", new BaybayinLetter[]{
                new BaybayinLetter("A", 335, 115, 32, 35),
                new BaybayinLetter("E", 335, 165, 32, 35),
                new BaybayinLetter("I", 335, 165, 32, 35),
                new BaybayinLetter("O", 335, 215, 32, 35),
                new BaybayinLetter("U", 335, 215, 32, 35),
                new BaybayinLetter("B", 335, 265, 32, 35),
                new BaybayinLetter("K", 335, 315, 32, 35),
                new BaybayinLetter("D", 335, 365, 32, 35),
                new BaybayinLetter("G", 335, 415, 32, 35),
                new BaybayinLetter("H", 335, 465, 32, 35),
                new BaybayinLetter("L", 335, 515, 32, 35),
                new BaybayinLetter("M", 335, 565, 32, 35),
                new BaybayinLetter("N", 335, 615, 32, 35),
                new BaybayinLetter("Ng", 332, 665, 38, 35),
                new BaybayinLetter("P", 335, 715, 32, 35),
                new BaybayinLetter("R", 335, 765, 32, 35),
                new BaybayinLetter("S", 335, 815, 32, 35),
                new BaybayinLetter("T", 335, 865, 32, 35),
                new BaybayinLetter("W", 335, 915, 32, 35),
                new BaybayinLetter("Y", 335, 965, 32, 35),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });


            Translation t4 = new Translation("Tagalog Stylized", new BaybayinLetter[]{
                new BaybayinLetter("A", 445, 115, 40, 39),
                new BaybayinLetter("E", 445, 165, 40, 39),
                new BaybayinLetter("I", 445, 165, 40, 39),
                new BaybayinLetter("O", 445, 215, 40, 39),
                new BaybayinLetter("U", 445, 215, 40, 39),
                new BaybayinLetter("B", 445, 265, 40, 39),
                new BaybayinLetter("K", 445, 315, 40, 39),
                new BaybayinLetter("D", 445, 365, 40, 39),
                new BaybayinLetter("G", 445, 415, 40, 39),
                new BaybayinLetter("H", 445, 465, 40, 39),
                new BaybayinLetter("L", 445, 515, 40, 39),
                new BaybayinLetter("M", 445, 565, 40, 39),
                new BaybayinLetter("N", 445, 615, 40, 39),
                new BaybayinLetter("Ng", 445, 665, 40, 39),
                new BaybayinLetter("P", 445, 715, 40, 39),
                new BaybayinLetter("R", 445, 765, 40, 39),
                new BaybayinLetter("S", 445, 815, 40, 39),
                new BaybayinLetter("T", 445, 865, 40, 39),
                new BaybayinLetter("W", 445, 915, 40, 39),
                new BaybayinLetter("Y", 445, 965, 40, 39),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });

            Translation t5 = new Translation("Kabena'o", new BaybayinLetter[]{
                new BaybayinLetter("A", 557, 113, 42, 40),
                new BaybayinLetter("E", 557, 163, 42, 40),
                new BaybayinLetter("I", 557, 163, 42, 40),
                new BaybayinLetter("O", 557, 213, 42, 40),
                new BaybayinLetter("U", 557, 213, 42, 40),
                new BaybayinLetter("B", 557, 263, 42, 40),
                new BaybayinLetter("K", 557, 313, 42, 40),
                new BaybayinLetter("D", 557, 363, 42, 40),
                new BaybayinLetter("G", 557, 413, 42, 40),
                new BaybayinLetter("H", 557, 463, 42, 40),
                new BaybayinLetter("L", 557, 513, 42, 40),
                new BaybayinLetter("M", 557, 563, 42, 40),
                new BaybayinLetter("N", 557, 613, 42, 40),
                new BaybayinLetter("Ng", 557, 663, 42, 40),
                new BaybayinLetter("P", 557, 713, 42, 40),
                new BaybayinLetter("R", 557, 763, 42, 40),
                new BaybayinLetter("S", 557, 813, 42, 40),
                new BaybayinLetter("T", 557, 863, 42, 40),
                new BaybayinLetter("W", 557, 913, 42, 40),
                new BaybayinLetter("Y", 557, 963, 42, 40),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });


            Translation t6 = new Translation("Bagoyin", new BaybayinLetter[]{
                new BaybayinLetter("A", 669, 115, 42, 40),
                new BaybayinLetter("E", 669, 165, 42, 40),
                new BaybayinLetter("I", 669, 165, 42, 40),
                new BaybayinLetter("O", 669, 215, 42, 40),
                new BaybayinLetter("U", 669, 215, 42, 40),
                new BaybayinLetter("B", 669, 265, 42, 40),
                new BaybayinLetter("K", 669, 315, 42, 40),
                new BaybayinLetter("D", 669, 365, 42, 40),
                new BaybayinLetter("G", 669, 415, 42, 40),
                new BaybayinLetter("H", 669, 465, 42, 40),
                new BaybayinLetter("L", 669, 515, 42, 40),
                new BaybayinLetter("M", 669, 565, 42, 40),
                new BaybayinLetter("N", 669, 615, 42, 40),
                new BaybayinLetter("Ng", 669, 665, 42, 40),
                new BaybayinLetter("P", 669, 715, 42, 40),
                new BaybayinLetter("R", 669, 765, 42, 40),
                new BaybayinLetter("S", 669, 815, 42, 40),
                new BaybayinLetter("T", 669, 865, 42, 40),
                new BaybayinLetter("W", 669, 915, 42, 40),
                new BaybayinLetter("Y", 669, 965, 42, 40),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });

            Translation t7 = new Translation("Nordenx", new BaybayinLetter[]{
                new BaybayinLetter("A", 797, 115, 35, 35),
                new BaybayinLetter("E", 797, 165, 35, 35),
                new BaybayinLetter("I", 797, 165, 35, 35),
                new BaybayinLetter("O", 797, 215, 35, 35),
                new BaybayinLetter("U", 797, 215, 35, 35),
                new BaybayinLetter("B", 797, 265, 35, 35),
                new BaybayinLetter("K", 797, 315, 35, 35),
                new BaybayinLetter("D", 797, 365, 35, 35),
                new BaybayinLetter("G", 797, 415, 35, 35),
                new BaybayinLetter("H", 797, 465, 35, 35),
                new BaybayinLetter("L", 797, 515, 35, 35),
                new BaybayinLetter("M", 797, 565, 35, 35),
                new BaybayinLetter("N", 797, 615, 35, 35),
                new BaybayinLetter("Ng", 797, 665, 35, 35),
                new BaybayinLetter("P", 797, 715, 35, 35),
                new BaybayinLetter("R", 797, 765, 35, 35),
                new BaybayinLetter("S", 797, 815, 35, 35),
                new BaybayinLetter("T", 797, 865, 35, 35),
                new BaybayinLetter("W", 797, 915, 35, 35),
                new BaybayinLetter("Y", 797, 965, 35, 35),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });

            Translation t8 = new Translation("Baybayin Eskriba Simplified", new BaybayinLetter[]{
                new BaybayinLetter("A", 937, 117, 35, 35),
                new BaybayinLetter("E", 937, 167, 35, 35),
                new BaybayinLetter("I", 937, 167, 35, 35),
                new BaybayinLetter("O", 937, 217, 35, 35),
                new BaybayinLetter("U", 937, 217, 35, 35),
                new BaybayinLetter("B", 937, 267, 35, 35),
                new BaybayinLetter("K", 937, 317, 35, 35),
                new BaybayinLetter("D", 937, 367, 35, 35),
                new BaybayinLetter("G", 937, 417, 35, 35),
                new BaybayinLetter("H", 937, 467, 35, 35),
                new BaybayinLetter("L", 937, 517, 35, 35),
                new BaybayinLetter("M", 937, 567, 35, 35),
                new BaybayinLetter("N", 937, 617, 35, 35),
                new BaybayinLetter("Ng", 937, 667, 35, 35),
                new BaybayinLetter("P", 937, 717, 35, 35),
                new BaybayinLetter("R", 937, 767, 35, 35),
                new BaybayinLetter("S", 937, 817, 35, 35),
                new BaybayinLetter("T", 937, 867, 35, 35),
                new BaybayinLetter("W", 937, 917, 35, 35),
                new BaybayinLetter("Y", 937, 967, 35, 35),
                
                new BaybayinLetter("IE", 22, 25, 15, 20),
                new BaybayinLetter("OU", 22, 25, 15, 20),
                new BaybayinLetter("NO_VOWEL", 22, 76, 10, 10)
            });

            translations.Add(t1);
            translations.Add(t2);
            translations.Add(t3);
            translations.Add(t4);
            translations.Add(t5);
            translations.Add(t6);
            translations.Add(t7);
            translations.Add(t8);

            SelectedTranslation = t1;

        }

        public void setTranslation(Translation t)
        {
            if (t != null)
                SelectedTranslation = t;
        }

        public bool isVowel(char c)
        {
            c = Char.ToLower(c);
            return c == 'a' ||
                   c == 'e' ||
                   c == 'i' ||
                   c == 'o' ||
                   c == 'u';
        }

        public List<string> getValidSyllables(string str)
        {
            List<string> l = new List<string>();
            char[] letters = str.ToLower().ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                char curr = letters[i];
                char next = (i < letters.Length - 1) ? letters[i + 1] : '\0';

                //if (curr == ' ' && next == ' ')
                //    continue;
                //else 
                if (curr != ' ' && curr != '\n')
                {
                    bool isNG = (curr == 'n' && next == 'g');
                    string syllable = char.ToUpper(curr) + (isNG ? "g" : "");
                    BaybayinLetter letter = this.SelectedTranslation.getBaybayinLetter(syllable);

                    if (letter != null)
                    {

                        if (isNG)
                        {
                            i++;
                            next = (i < letters.Length - 1) ? letters[i + 1] : '\0';
                        }

                        if (this.isVowel(next))
                        {
                            i++;
                            syllable += next;
                        }

                        l.Add(syllable);
                    }
                }
                else if (curr == '\n')
                    l.Add("\n");
                else if (curr == ' ')
                    l.Add(" ");

            }
            return l;
        }
    }
}

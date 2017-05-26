using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma {
    class cWalze {
        private int[] fVerschluesselungstabelle;

        public cWalze(int pWalzennummer) {
            switch (pWalzennummer) {
                case 1:
                    fVerschluesselungstabelle = BerechneCodierung("EKMFLGDQVZNTOWYHXUSPAIBRCJ");
                    break;
                case 2:
                    fVerschluesselungstabelle = BerechneCodierung("AJDKSIRUXBLHWTMCQGZNPYFVOE");
                    break;
                case 3:
                    fVerschluesselungstabelle = BerechneCodierung("BDFHJLCPRTXVZNYEIWGAKMUSQO");
                    break;                 
                case 4:
                    fVerschluesselungstabelle = BerechneCodierung("ESOVPZJAYQUIRHXLNFTGKDCMWB");
                    break;
                case 5:
                    fVerschluesselungstabelle = BerechneCodierung("VZBRGITYUPSDNHLXAWMJQOFECK");
                    break;
            }
        }

        private int[] BerechneCodierung(string pWalzenCode) {
            int[] codierung = new int[26];
            var counter = 0;

            foreach(char i in pWalzenCode) {
                var currentValue = (counter + 1) + (int) char.GetNumericValue(i);
                if (currentValue > 90)
                    currentValue -= 26;
                codierung[counter] = currentValue;
            }

            return codierung;
        }
    }
}

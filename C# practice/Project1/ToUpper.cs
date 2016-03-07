using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

    public class ToUpper

    {

        string myString;
        char[] UppercaseLetters = new char[26]
        {
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z'
        };

        public ToUpper(string mystring)
        {
            myString = mystring;
        }

        public string CustomToUpper()
        {
            char[] mystringToChar;
            mystringToChar = myString.ToCharArray();

            for (int i = 0; i < mystringToChar.Length; i++)
            {
                switch (mystringToChar[i])
                {
                    case 'a':
                        mystringToChar[i] = UppercaseLetters[0];
                        break;
                    case 'b':
                        mystringToChar[i] = UppercaseLetters[1];
                        break;
                    case 'c':
                        mystringToChar[i] = UppercaseLetters[2];
                        break;
                    case 'd':
                        mystringToChar[i] = UppercaseLetters[3];
                        break;
                    case 'e':
                        mystringToChar[i] = UppercaseLetters[4];
                        break;
                    case 'f':
                        mystringToChar[i] = UppercaseLetters[5];
                        break;
                    case 'g':
                        mystringToChar[i] = UppercaseLetters[6];
                        break;
                    case 'h':
                        mystringToChar[i] = UppercaseLetters[7];
                        break;
                    case 'i':
                        mystringToChar[i] = UppercaseLetters[8];
                        break;
                    case 'j':
                        mystringToChar[i] = UppercaseLetters[9];
                        break;
                    case 'k':
                        mystringToChar[i] = UppercaseLetters[10];
                        break;
                    case 'l':
                        mystringToChar[i] = UppercaseLetters[11];
                        break;
                    case 'm':
                        mystringToChar[i] = UppercaseLetters[12];
                        break;
                    case 'n':
                        mystringToChar[i] = UppercaseLetters[13];
                        break;
                    case 'o':
                        mystringToChar[i] = UppercaseLetters[14];
                        break;
                    case 'p':
                        mystringToChar[i] = UppercaseLetters[15];
                        break;
                    case 'q':
                        mystringToChar[i] = UppercaseLetters[16];
                        break;
                    case 'r':
                        mystringToChar[i] = UppercaseLetters[17];
                        break;
                    case 's':
                        mystringToChar[i] = UppercaseLetters[18];
                        break;
                    case 't':
                        mystringToChar[i] = UppercaseLetters[19];
                        break;
                    case 'u':
                        mystringToChar[i] = UppercaseLetters[20];
                        break;
                    case 'v':
                        mystringToChar[i] = UppercaseLetters[21];
                        break;
                    case 'w':
                        mystringToChar[i] = UppercaseLetters[22];
                        break;
                    case 'x':
                        mystringToChar[i] = UppercaseLetters[23];
                        break;
                    case 'y':
                        mystringToChar[i] = UppercaseLetters[24];
                        break;
                    case 'z':
                        mystringToChar[i] = UppercaseLetters[25];
                        break;
                    default:
                        break;
                }
                string output = "";
                for (int x = 0; x < mystringToChar.Length; x++)
                {
                    
                    output += mystringToChar[x];
                }
                myString = output;
            }
            return myString;
        }
        public void display()
        {
            Console.WriteLine(myString);
        }
    }
}

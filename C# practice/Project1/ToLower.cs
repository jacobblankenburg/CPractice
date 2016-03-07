using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class ToLower

    {

        string myString;
        char[] LowercaseLetters = new char[26]
        {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z'
        };

        public ToLower(string mystring)
        {
            myString = mystring;
        }

        public string CustomToLower()
        {
            char[] mystringToChar;
            mystringToChar = myString.ToCharArray();

            for (int i = 0; i < mystringToChar.Length; i++)
            {
                switch (mystringToChar[i])
                {
                    case 'A':
                        mystringToChar[i] = LowercaseLetters[0];
                        break;
                    case 'B':
                        mystringToChar[i] = LowercaseLetters[1];
                        break;
                    case 'C':
                        mystringToChar[i] = LowercaseLetters[2];
                        break;
                    case 'D':
                        mystringToChar[i] = LowercaseLetters[3];
                        break;
                    case 'E':
                        mystringToChar[i] = LowercaseLetters[4];
                        break;
                    case 'F':
                        mystringToChar[i] = LowercaseLetters[5];
                        break;
                    case 'G':
                        mystringToChar[i] = LowercaseLetters[6];
                        break;
                    case 'H':
                        mystringToChar[i] = LowercaseLetters[7];
                        break;
                    case 'I':
                        mystringToChar[i] = LowercaseLetters[8];
                        break;
                    case 'J':
                        mystringToChar[i] = LowercaseLetters[9];
                        break;
                    case 'K':
                        mystringToChar[i] = LowercaseLetters[10];
                        break;
                    case 'L':
                        mystringToChar[i] = LowercaseLetters[11];
                        break;
                    case 'M':
                        mystringToChar[i] = LowercaseLetters[12];
                        break;
                    case 'N':
                        mystringToChar[i] = LowercaseLetters[13];
                        break;
                    case 'O':
                        mystringToChar[i] = LowercaseLetters[14];
                        break;
                    case 'P':
                        mystringToChar[i] = LowercaseLetters[15];
                        break;
                    case 'Q':
                        mystringToChar[i] = LowercaseLetters[16];
                        break;
                    case 'R':
                        mystringToChar[i] = LowercaseLetters[17];
                        break;
                    case 'S':
                        mystringToChar[i] = LowercaseLetters[18];
                        break;
                    case 'T':
                        mystringToChar[i] = LowercaseLetters[19];
                        break;
                    case 'U':
                        mystringToChar[i] = LowercaseLetters[20];
                        break;
                    case 'V':
                        mystringToChar[i] = LowercaseLetters[21];
                        break;
                    case 'W':
                        mystringToChar[i] = LowercaseLetters[22];
                        break;
                    case 'X':
                        mystringToChar[i] = LowercaseLetters[23];
                        break;
                    case 'Y':
                        mystringToChar[i] = LowercaseLetters[24];
                        break;
                    case 'Z':
                        mystringToChar[i] = LowercaseLetters[25];
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpday4
{
    class StringManip
    {
        public void vertical(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text.Substring(i, 1));
            }
        }

        public void wordVertical(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Substring(i, 1) == " ")
                {
                    Console.WriteLine();
                } else
                {
                    Console.Write(text.Substring(i, 1));
                }

            }
        }

        public void reverseSentence(string txt)
        {
            txt = String.Join(" ", txt.Split(' ').Reverse());

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt.Substring(i, 1) == " "
)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(txt.Substring(i, 1));
                }
            }
        }

        public void reverse2(string txt)
        {
            string word = "";
            for (int i = txt.Length -1; i >= 0; i--)
            {
                if (txt.Substring(i, 1) == " ")
                {
                    Console.WriteLine(word);
                    word = "";
                }
                else
                {
                    word = txt.Substring(i, 1) + word;
                }
            }

            Console.WriteLine(word);
        }

        public void reverse3(string txt)
        {
            string word = " ";

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt.Substring(i, 1) == " ")
                {
                    Console.Write(word);
                    word = " ";
                }
                else
                {
                    word = txt.Substring(i, 1) + word;
                }
            }
            Console.Write(word.TrimEnd());
        }

        public void finalReverse(string msg)
        {
            string newMsg = "";
            string newWord = "";

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg.Substring(i, 1) == " ")
                {
                    newMsg = newMsg + reverse(newWord) + " ";
                    newWord = "";
                }
                else
                {
                    newWord = newWord + msg.Substring(i, 1);
                }
            }
            newMsg = newMsg + reverse(newWord) + " ";
            Console.WriteLine(newMsg);
        }

        private string reverse(string word)
        {
            string newWord = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                newWord = newWord + word.Substring(i, 1);
            }
            return newWord;
        }

        // doesn't work 

        public void wordCount(string text)
        {
            int space = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    space++;
                }
            }
            Console.WriteLine("Word Count = " + (space + 1));
        }

        private string checkLength(string current, string longest)
        {
            if (current.Length > longest.Length)
            {
                longest = current;
            }
            return longest;
        }

        public void longestWord(string txt)
        {
            string word = "";
            string longest = "";
            string msg = "";
            string longestWord = "";

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt.Substring(i, 1) == " ")
                {
                    msg += word + " ";

                    longestWord = checkLength(word, longest);

                    word = "";
                } else
                {
                    word = word + txt.Substring(i, 1);

                }
            }
            Console.WriteLine("Longest word = " + longest);
        }

    }
}

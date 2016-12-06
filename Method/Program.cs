﻿using System;
using System.Linq;

namespace Method
{
    public class lab5
    {
    }
    public class lab6
    {
        public static int exe1_spaceFinder(string istring)
        {
            char[] jstring = istring.ToCharArray();
            char[] filter = { ' ' };
            int count = 0;

            foreach (char tempfor in jstring)
            {
                if (filter.Contains(tempfor))
                    count++;
            }
            return count;
        }

        public static int exe3_famFinder(string ifam, string jfam, string lfam, string search)
        {
            int sovpad = 0;
            char[] separators = { ',', ' ', ';' };

            string[] ifam_words = ifam.ToUpper().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] jfam_words = jfam.ToUpper().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] lfam_words = lfam.ToUpper().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in ifam_words)
            {
                if (search.ToUpper().Equals(word))
                {
                    sovpad++;
                    break;
                }
            }
            foreach (string word in jfam_words)
            {
                if (search.ToUpper().Equals(word))
                {
                    sovpad++;
                    break;
                }
            }
            foreach (string word in lfam_words)
            {
                if (search.ToUpper().Equals(word))
                {
                    sovpad++;
                    break;
                }
            }
            return sovpad;
        }
        public static int exe4_wordsFinder(string offer)
        {
            char[] separators = { ',', ' ', ';', '.' };

            string[] offer_words = offer.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return offer_words.Length;
        }
        public static int[] exe5_cyrAlphabet(string text)
        {
            char[] mainstring = text.ToCharArray();
            char[] jfilter = { 'б', 'п', 'в', 'ф', 'д', 'т', 'з', 'с', 'ж', 'ш', 'ч', 'ц', 'щ', 'г', 'к', 'х', 'м', 'н', 'л', 'р' };
            char[] ifilter = { 'а', 'э', 'о', 'ы', 'и', 'у', 'я', 'е', 'ё', 'ю' };
            int[] alphabet = { 0, 0 };
            int icount = 0, jcount = 0;
            

            foreach (char itempfor in mainstring)
            {
                if (ifilter.Contains(itempfor))
                    icount++;
            }

            foreach (char jtempfor in mainstring)
            {
                if (jfilter.Contains(jtempfor))
                    jcount++;
            }

            alphabet[0] = icount;
            alphabet[1] = jcount;

            return alphabet;
        }
        public static string[] exe6_textRevers(string words)
        {
            char[] separators = { ',', ' ', ';' };
            string[] iwords = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(iwords);

            for (int i = 0; i < iwords.Length; i++)
            {
                iwords[i] = iwords[i].Remove(iwords[i].Length - 1, 1) + (string)(iwords[i].Remove(0, iwords[i].Length - 1)).ToUpper();
                iwords[i] = (string)(iwords[i].Remove(1, iwords[i].Length - 1)).ToUpper() + iwords[i].Remove(0, 1);
            }
            return iwords;
        }
        public static void exe7_wordReverse(string word)
        {
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < word.Length; i++)
            {
                var index = abc.IndexOf(word[i]);
                if (index + 1 <= 26)
                {
                    Console.Write(abc[index + 26]);
                }
                else
                {
                    Console.Write(abc[index - 26]);
                }
            }
        }
    }
}
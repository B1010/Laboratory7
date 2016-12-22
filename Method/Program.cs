using System;
using System.Linq;
using System.Text;

namespace Method
{
    public class lab5
    {
    }
    public class lab6
    {
        public int exe1_spaceFinder(string istring)
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
        public void exe2_charFinder(string text, string charfind)
        {
            int k = 0;
            k = text.IndexOf(charfind);

            if (k != -1)
            {
                for (int i = 0; i <= text.Length - 1; i++)
                {
                    if (text.Substring(i, 1) == charfind)
                    {
                        if (i == 0) Console.WriteLine("Последующий символ: " + text.Substring(i + 1, 1));
                        if (i == text.Length - 1) Console.WriteLine("Предыдущий символ: " + text.Substring(i - 1, 1));
                        if ((i != 0) && (i != text.Length - 1))
                        {
                            Console.WriteLine("Предыдущий символ: " + text.Substring(i - 1, 1));
                            Console.WriteLine("Последующий символ: " + text.Substring(i + 1, 1));
                        }
                    }
                }
            }
            else Console.WriteLine("Такого символа нет");
        }
        public int exe3_famFinder(string ifam, string jfam, string lfam, string search)
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
        public int exe4_wordsFinder(string offer)
        {
            char[] separators = { ',', ' ', ';', '.' };

            string[] offer_words = offer.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return offer_words.Length;
        }
        public int[] exe5_cyrAlphabet(string text)
        {
            char[] mainstring = text.ToCharArray();
            char[] jfilter = { 'б', 'п', 'в', 'ф', 'д', 'т', 'з', 'с', 'ж', 'ш', 'ч', 'ц', 'щ', 'г', 'к', 'х', 'м', 'н', 'л', 'р' };
            char[] ifilter = { 'а', 'э', 'о', 'ы', 'и', 'у', 'я', 'е', 'ё', 'ю' };
            int[] alphabet = { 0, 0 };

            foreach (char itempfor in mainstring)
            {
                if (ifilter.Contains(itempfor))
                    alphabet[0]++;
            }

            foreach (char jtempfor in mainstring)
            {
                if (jfilter.Contains(jtempfor))
                    alphabet[1]++;
            }

            return alphabet;
        }
        public string[] exe6_textRevers(string words)
        {
            char[] separators = { ',', ' ', ';' };
            string[] iwords = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(iwords);

            for (int i = 0; i < iwords.Length; i++)
            {
                iwords[i] = iwords[i].Remove(iwords[i].Length - 1, 1) + (iwords[i].Remove(0, iwords[i].Length - 1)).ToUpper();
                iwords[i] = (iwords[i].Remove(1, iwords[i].Length - 1)).ToUpper() + iwords[i].Remove(0, 1);
            }
            return iwords;
        }
        public void exe7_wordReverse(string word)
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
        public int[] exe8_Digit(string text)
        {
            char[] mainstring = text.ToCharArray();
            char[] jfilter = { '!', '"', ';', ':', '.', ',', '-', '/', '\\', '=', '+', '_', '?', '[', ']', '{', '}', '(', ')', '*' };
            char[] ifilter = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int[] digits = { 0, 0 };

            foreach (char itempfor in mainstring)
            {
                if (ifilter.Contains(itempfor))
                    digits[0]++;
            }

            foreach (char jtempfor in mainstring)
            {
                if (jfilter.Contains(jtempfor))
                    digits[1]++;
            }

            return digits;
        }
        public int exe9_substring(string textFind, string substring)
        {
            int index = 0;

            if (textFind.IndexOf(substring) > -1)
            {
                index = textFind.IndexOf(substring) + 1;
                return index;
            }
            else
            {
                return 0;
            }
        }
        public string exe10_wordtodash(string text)
        {
            char[] separators = { ',', ' ', ';' };
            string[] text_arr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in text_arr)
            {
                if (item.Length < 3) text = text.Replace(item, "-");
            }
            return text;
        }
        public string exe11_ATE(string phoneNumber)
        {
            char[] separators = { ',', ' ', ';', '-', '+' };
            string[] phoneNumber_arr = phoneNumber.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return phoneNumber_arr[2];
        }
        public int[] exe12_USAtoRUSdate(string dateUSA)
        {
            int[] dateRUS = { 0, 0, 0 };
            char[] separators = { '/' };
            int[] dateUSA_arr = dateUSA.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray(); ;

            dateRUS[0] = dateUSA_arr[1];
            dateRUS[1] = dateUSA_arr[0];
            dateRUS[2] = dateUSA_arr[2];

            return dateRUS;
        }
        public string[] exe13_timeStringandStringBuilder()
        {
            string[] timedelay = { "", "" };

            DateTime time0 = DateTime.Now;
            strA();
            TimeSpan time0_0 = DateTime.Now - time0;

            DateTime time1 = DateTime.Now;
            strB();
            TimeSpan time1_1 = DateTime.Now - time1;

            timedelay[0] = time0_0.ToString();
            timedelay[0] = time1_1.ToString();

            return timedelay;
        }
        private void strA()
        {
            String strA = "";
            for (int i = 0; i < 50000; i++)
            {
                strA = strA + i;
            }
        }
        private void strB()
        {
            var strB = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                strB.Append(i);
            }
            string str = strB.ToString();
        }
        public StringBuilder exe14_TextLineAdder(string text, int length, char replace)
        {
            StringBuilder newtext = new StringBuilder(text, length);

            if (length < text.Length)
            {
                newtext.Remove(length, newtext.Length - length);
            }
            else
                for (int i = 0; i <= (length - text.Length); i++)
                {
                    newtext.Insert(0, replace);
                }
            return newtext;
        }
        public StringBuilder exe15_texdCrupt(string pred, int key)
        {
            StringBuilder crupted = new StringBuilder(pred);

            for (int i = 0; i <= pred.Length; i++)
            {
                crupted.Insert(0, key);
                if (pred.Length < crupted.Length)
                {
                    crupted.Remove(pred.Length, crupted.Length - pred.Length);
                }
            }
            return crupted;
        }
    }
}
using System;
using System.Linq;
using System.Text;

namespace Method
{
    public class lab5
    {
        public int[] exe1_minandmax(int[,] iarray)
        {
            int[] minamdmax = new int[1];

            for (int i = 0; i < iarray.Length; i++)
            {
                for (int j = 0; j < iarray.Length; j++)
                {
                    iarray[i, j] = random.Next(10);
                }
            }

            minamdmax[0] = iarray[0, 0];
            for (int i = 0; i < iarray.GetLength(0); i++)
            {
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    if (minamdmax[0] < iarray[i, j])
                    {
                        minamdmax[0] = iarray[i, j];
                    }
                }
            }

            minamdmax[1] = iarray[0, 0];
            for (int i = 0; i < iarray.GetLength(0); i++)
            {
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    if (minamdmax[1] > iarray[i, j])
                    {
                        minamdmax[1] = iarray[i, j];
                    }
                }
            }
            return minamdmax;
        }
        public int exe2_minamdmaxsumm(int[] iarray)
        {
            int sum = 0;
            int min = iarray[0];
            foreach (int i in iarray)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            int max = iarray[0];
            foreach (int i in iarray)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            int MinIndex = 0, MaxIndex = 0;
            for (int i = 0; i < iarray.Length; i++)
            {
                if (iarray[i] == min)
                    MinIndex = i;
                if (iarray[i] == max)
                    MaxIndex = i;
            }

            if (MaxIndex > MinIndex)
            {
                for (int i = MinIndex + 1; i <= MaxIndex - 1; i++)
                {
                    sum = sum + iarray[i];
                }
                return sum;
            }
            else
            {
                return sum = 0;
            }
        }
        public int exe3_digitmaxline(int[] iarray)
        {
            int max = 0;

            for (int i = 0, temp2 = 1; i <= iarray.Length - 1; i++)
            {
                if (i != iarray.Length - 1)
                {
                    if (iarray[i] < iarray[i + 1])
                        temp2++;
                    else
                    {
                        if (temp2 > max)
                            max = temp2;
                        temp2 = 1;
                    }
                }
                else
                {
                    if (temp2 > max)
                        max = temp2;
                }
            }
            return max;
        }
        public int[] exe4_arrayincluder(int[] iarray, int[] jarray)
        {
            int index = 1, count = 0;
            
            int[] larray = new int[iarray.Length + jarray.Length], tarray = new int[iarray.Length + jarray.Length];
            
            for (int i = 0; i < iarray.Length; i++)
            {
                larray[i] = iarray[i];
            }
            for (int i = 0; i < jarray.Length; i++)
            {
                larray[iarray.Length + i] = jarray[i];
            }

            for (int i = 0; i < larray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < larray.Length; j++)
                {
                    if (larray[j] < larray[min])
                    {
                        min = j;
                    }
                }
                int temp = larray[min] = larray[i];
            }
            tarray[0] = larray[0];
            for (int i = 1; i < larray.Length; i++)
            {
                if (larray[i] != larray[i - 1])
                {
                    tarray[index] = larray[i];
                    index++;
                }
                else count++;
            }
            return tarray;
        }
        public int exe5_minofdigitsstartandens(int[] iarray)
        {
            int sum = 0;

            int min = sum = iarray[0] + iarray[iarray.Length - 1];
            for (int i = 0; i < iarray.Length; i++)
            {
                sum = iarray[i] + iarray[iarray.Length - 1 - i];
                if (sum < min)
                    min = sum;
            }
            return min;
        }
        public int exe6_summdigitsofthree(int[] iarray)
        {
            int sum = iarray[0] + iarray[1] + iarray[2];
            for (int i = 1; i < iarray.Length - 2; i++)
            {
                if (sum < (iarray[i] + iarray[i + 1] + iarray[i + 2]))
                {
                    sum = iarray[i] + iarray[i + 1] + iarray[i + 2];
                }
            }
            return sum;
        }
        public int[,] exe7_fromarraytoarray(int[,] iarray, int[] vector)
        {
            int[,] result = new int[iarray.GetLength(0), iarray.GetLength(1)];
            
            for (int i = 0; i < iarray.GetLength(1); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    result[i, j] = iarray[vector[i] - 1, j];
                }
            }
            return result;
        }
        public int[] exe8_linecolum_maxandmin(int[,] iarray)
        {
            int k = 0;
            int[] arrayline = new int[iarray.GetLength(0)];
            int[] arraycolu = new int[iarray.GetLength(1)];
            int[] maxandmin = new int[1];

            if (iarray.GetLength(0) != iarray.GetLength(1))
            {
                return maxandmin;
            }

            for (int i = 0, sum = 0; i < iarray.GetLength(0); i++, k++)
            {
                for (int j = 0; j < iarray.GetLength(0); j++)
                {
                    sum += iarray[i, j];
                }
                arrayline[k] = sum;
                sum = 0;
            }
            maxandmin[0] = arrayline[0];
            for (int g = 0; g < iarray.GetLength(0); g++)
            {
                if (maxandmin[0] < arrayline[g])
                {
                    maxandmin[0] = arrayline[g];
                }
            }
            for (int i = 0, f = 0, sum = 0; i < iarray.GetLength(1); i++, f++)
            {
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    sum += iarray[j, i];
                }
                arraycolu[f] = sum;
                sum = 0;
            }
            maxandmin[1] = arraycolu[0];
            for (int b = 0; b < iarray.GetLength(1); b++)
            {
                if (maxandmin[1] < arraycolu[b])
                {
                    maxandmin[1] = arraycolu[b];
                }

            }
            return maxandmin;
        }
        public int[,] exe10_AtoT(int[,] iarray)
        {
            Random randomforarray = new Random();
            Console.Write("Введите размер матрицы: ");
            int arraysize = int.Parse(Console.ReadLine());

            for (int i = 0; i < iarray.GetLength(0); i++)
            {
                for (int j = i; j < iarray.GetLength(1); j++)
                {
                    int temp = iarray[i, j];
                    iarray[i, j] = iarray[j, i];
                    iarray[j, i] = temp;
                }
            }
            return iarray;
        }
        public int[] exe11_sortandrevers(int[] iarray)
        {
            for (int i = 0; i < iarray.Length; i++)
            {
                for (int j = 0; j < iarray.Length - 1; j++)
                {
                    if (iarray[j] > iarray[j + 1])
                    {
                        int z = iarray[j];
                        iarray[j] = iarray[j + 1];
                        iarray[j + 1] = z;
                    }
                }
            }
            Array.Reverse(iarray);
            return iarray;
        }
        public int[,] exe12_9x9to3x3(int[,] iarray)
        {
            int newi, newj;
            int[,] jarray = new int[3, 3];

            if (iarray.GetLength(0) != 9 && iarray.GetLength(1) != 9)
            {
                return jarray;
            }

            for (int i = 0; i < iarray.GetLength(0); i++)
            {
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    if (i <= 2)
                        newi = 0;
                    else
                    {
                        if (i > 2 && i <= 5) newi = 1;
                        else newi = 2;
                    }
                    if (j <= 2) newj = 0;
                    else
                    {
                        if (j > 2 && j <= 5) newj = 1;
                        else newj = 2;
                    }
                    jarray[newi, newj] = jarray[newi, newj] + iarray[i, j];
                }
            }
            return jarray;
        }
    }
    public class lab6
    {
        public int exe1_spaceFinder(string istring)
        {
            return istring.Split(' ').Length - 1;
        }
        public string[] exe2_charFinder(string text, string charfind)
        {
            int k = 0, d = 0;
            string[] chartoreturn = new string[100];
            k = text.IndexOf(charfind);

            if (k != -1)
            {
                for (int i = 0; i <= text.Length - 1; i++)
                {
                    if (text.Substring(i, 1) == charfind)
                    {
                        d++;
                        if (i == 0)
                        {
                            chartoreturn[d] = text.Substring(i + 1, 1);// Последующий символ
                        }
                        if (i == text.Length - 1)
                        {
                            chartoreturn[d + 1] = text.Substring(i - 1, 1);// Предыдущий символ
                        }
                        if ((i != 0) && (i != text.Length - 1))
                        {
                            chartoreturn[d] = text.Substring(i - 1, 1); // Предыдущий символ
                            chartoreturn[d + 1] = text.Substring(i + 1, 1); // Последующий символ
                        }
                    }
                }
            }
            return chartoreturn;
        }
        public int exe3_famFinder(string[] family, string search)
        {
            int sovpad = 0, g = 0, x = -1;

            foreach (string word in family)
            {
                while (g != -1)
                {
                    g = word.IndexOf(search.ToUpper(), x + 1);
                    x = g;
                    sovpad++;
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
        public string[] exe7_wordReverse(string word)
        {
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] result = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                var index = abc.IndexOf(word[i]);
                if (index + 1 <= 26)
                {
                    result[i] = abc[index + 26].ToString();
                }
                else
                {
                    result[i] = abc[index - 26].ToString();
                }
            }
            return result;
        }
        public int[] exe8_Digit(string text)
        {
            char[] mainstring = text.ToCharArray();
            int[] result = new int[1];

            foreach (char itempfor in mainstring)
            {
                if (char.IsDigit(itempfor))
                    result[0]++;
            }

            foreach (char jtempfor in mainstring)
            {
                if (char.IsSymbol(jtempfor))
                    result[1]++;
            }

            return result;
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
            char[] separators = { ',', ' ', ';', '-', '+', '(', ')' };
            string[] phoneNumber_arr = phoneNumber.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (phoneNumber_arr.Length == 5)
            {
                return phoneNumber_arr[2];
            }

            if (phoneNumber_arr.Length == 3)
            {
                return phoneNumber_arr[0];
            }
        }
        public int[] exe12_USAtoRUSdate(string dateUSA)
        {
            int[] dateRUS = { 0, 0, 0 };
            char[] separators = { '/' };
            int[] dateUSA_arr = dateUSA.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

            dateRUS[0] = dateUSA_arr[1];
            dateRUS[1] = dateUSA_arr[0];
            dateRUS[2] = dateUSA_arr[2];

            return dateRUS;
        }
        public string[] exe13_timeStringandStringBuilder()
        {
            string[] timedelay = { "", "" };
            
            timedelay[0] = strA();
            timedelay[0] = strB();

            return timedelay;
        }
        private string strA()
        {
            DateTime time0 = DateTime.Now;
            String strA = "";
            for (int i = 0; i < 50000; i++)
            {
                strA = strA + i;
            }
            TimeSpan time0_0 = DateTime.Now - time0;
            return time0_0.ToString();
        }
        private string strB()
        {
            DateTime time1 = DateTime.Now;
            var strB = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                strB.Append(i);
            }
            string str = strB.ToString();
            TimeSpan time1_1 = DateTime.Now - time1;
            return time1_1.ToString();
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
        public string[] exe15_texdCrupt(string text, int key)
        {
            int outofrangeunicode = (int)'0';
            string[] result = new string[2];

            StringBuilder init0 = new StringBuilder(text);
            StringBuilder init1 = new StringBuilder(text);
            for (int count = 0; count < text.Length; count++)
            {
                init0.Insert(0, key);
            }
            if (text.Length < init0.Length)
            {
                init0.Remove(text.Length, init0.Length - text.Length);
            }
            StringBuilder init2 = new StringBuilder(text);
            StringBuilder init3 = new StringBuilder(text);
            for (int count = 0; count < text.Length; count++)
            {
                init3[count] = (char)((int)init2[count] + ((int)init0[count] - outofrangeunicode));
            }
            for (int count = 0; count < text.Length; count++)
            {
                init1[count] = (char)((int)init3[count] - ((int)init0[count] - outofrangeunicode));
            }
            result[0] = init3.ToString();
            result[1] = init1.ToString();
        }
    }
}
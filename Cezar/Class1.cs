using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezar
{
    class Cezar
    {
        private static string alpha = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя !?.,:;0123456789-";
        private static char[] newAlpha = new char[84];

        public static string encrypt(string Message)
        {
            string res = "";
            foreach (char ch in Message)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    if (ch == alpha[i])
                    {
                        res += newAlpha[i];
                        break;
                    }
                }
            }
            return res;
        }

        public static string decrypt(string Message)
        {
            string res = "";
            foreach (char ch in Message)
            {
                for (int i = 0; i < newAlpha.Length; i++)
                {
                    if (ch == newAlpha[i])
                    {
                        res += alpha[i];
                        break;
                    }
                }
            }
            return res;
        }

        public static void createNewAlpha(string keyWord, int key)
        {
            bool findSame = false;
            key--;
            int beg = 0, current = key;
            for (int i = key; i < keyWord.Length + key; i++)
            {
                for (int j = key; j < keyWord.Length + key; j++)
                {
                    if (keyWord[i - key] == newAlpha[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newAlpha[current] = keyWord[i - key];
                    current++;
                }
                findSame = false;
            }

            for (int i = 0; i < alpha.Length; i++)
            {
                for (int j = 0; j < newAlpha.Length; j++)
                {
                    if (alpha[i] == newAlpha[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newAlpha[current] = alpha[i];
                    current++;
                }
                findSame = false;
                if (current == newAlpha.Length)
                {
                    beg = i;
                    break;
                }
            }

            current = 0;
            for (int i = beg; i < alpha.Length; i++)
            {
                for (int j = 0; j < newAlpha.Length; j++)
                {
                    if (alpha[i] == newAlpha[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newAlpha[current] = alpha[i];
                    current++;
                }
                findSame = false;
            }
        }

        public static string getNewAlpha()
        {
            string strNewAlpha = new string(newAlpha);
            return strNewAlpha;
        }
    }
}

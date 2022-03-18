using System;
using System.Collections.Generic;
using System.Text;

namespace STATIC.Utils
{
    public static class ExtentionMethods
    {
        


        public static bool IsOdd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
                return false;

        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            } 
            return false;
        }
        public static bool IsContainsDigit(this string charachter)
        {
            foreach (char item in charachter)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            
           
            return false;
        }
        public static string ToCapitalize(this string words)
        {
            return words.Substring(0, 1).ToUpper() + words.Substring(1);
            //StringBuilder stringBuilder = new StringBuilder();   
            //var firstChar=char.ToUpper(words[0]);
            //for (int i =1; i< words.Length; i ++)
            //{
            //    stringBuilder.Append(words[i]);
            //}
            //return stringBuilder.ToString();
           
        }
            public static int [] GetValueIndexes(this string str,char c)
        {
            int [] indexes = new int [0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==c)
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length-1] = i;    
                }
                
            }
            return indexes;
        }
	

	}

       

 } 


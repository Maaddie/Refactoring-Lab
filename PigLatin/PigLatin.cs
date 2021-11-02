using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    //Created the PigLatin object
    class PigLatin
    {

        //Removed stativ from this bool method as well for the same reason as below
        public  bool IsVowel(char c)
        {
            //making this a list so we can use the .Contains method to check for the vowels.
            List <char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            //this will return c if it is a vowel or not
            return vowels.Contains(c);
            
            //if you tostring a list, it will make a string value of the datatype
            //return c.ToString() == vowels.ToString();
        }

        //removed 'static' from this method as the static method would keep only one copy of the method at the type level and not object level.
        public string ToPigLatin(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                    
                }

            }

            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                return word;
            }

            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                output = word + "ay";
            }
            else
            {
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 0; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                string sub = word.Substring(vowelIndex + 1);
                string postFix = word.Substring(0, vowelIndex - 1);

                output = sub + postFix + "ay";
            }

            return output;
        }
    }
}

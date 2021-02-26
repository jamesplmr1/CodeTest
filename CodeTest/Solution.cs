using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class Solution
    {
        public string[] sentences;
        public int LongestSentenceIndex;
        public int solution(string S)
        {
            BreakStringIntoSentences(S);
            return FindLongestSentence();
        }

        public string[] BreakStringIntoSentences(string s)
        {
            return sentences = s.Split(new char[] { '.', '?', '!' });
        }

        public int FindLongestSentence()
        {
            int finalCount = 0;
            string[][] sentenceWords = new string[sentences.Length][];

            for (int i = 0; i < sentenceWords.Length; i++)  
            {
                string[] words = sentences[i].Split(' ');

                if(words[0] == "")
                {
                    words = words.Where(val => val != "").ToArray();
                }

                string sentence = sentences[i];
                sentenceWords[i] = words;
                int count = sentenceWords[i].Length;


                if (count > finalCount)
                {
                    finalCount = count;
                    LongestSentenceIndex = i;
                }
            }

            return finalCount; 
        }

        public void GetWordCountForEachSentance()
        {
            throw new NotImplementedException();
        }

        public int CompareWordCount()
        {
            int longestSentence = 1;
            return longestSentence;
        }
    }
}
using System.IO;

namespace TypingGame
{
    using System.Collections.Generic;
    using UnityEngine;

    public class WordGenerator : MonoBehaviour
    {
        private static List<string> wordList ;
        
        private static void PopulateWordList()
        {
            string[] AllWords = File.ReadAllLines(Path.Combine(Application.streamingAssetsPath, "words.txt"));
            wordList = new List<string>(AllWords);
        }
        
        public static string GetRandomWord()
        {
            if (wordList == null || wordList.Count == 0)
            {
                PopulateWordList();
            }

            if (wordList == null || wordList.Count == 0)
            {
                return "WordListWasEmpty";
            }
            
            return wordList[Random.Range(0, wordList.Count)];
        }
    }
}

namespace TypingGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WordGenerator : MonoBehaviour
    {
        private static string[] wordList = { "word", "fuck", "shit", "sex"};
        
        public static string GetRandomWord()
        {
            return wordList[Random.Range(0, wordList.Length)];
        }
    }
}

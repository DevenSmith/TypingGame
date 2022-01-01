namespace TypingGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [System.Serializable]
    public class Word
    {
        [SerializeField]
        private string word;
        
        private int typeIndex = 0;
        private WordDisplay display;
        
        public Word(string _word, WordDisplay _display)
        {
            word = _word;
            
            if (_display != null)
            {
                display = _display;
                display.SetWord(word);
            }
        }

        public char GetNextLetter()
        {
            return word[typeIndex];
        }

        public void TypeLetter()
        {
            typeIndex++;
            if (display != null)
            {
                display.RemoveLetter();
            }
        }

        public bool WordTyped()
        {
            bool wordTyped = (typeIndex >= word.Length);

            if (wordTyped && display != null)
            {
                display.RemoveWord();
            }

            return wordTyped;
        }
    }
}

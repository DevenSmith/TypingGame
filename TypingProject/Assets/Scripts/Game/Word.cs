using Devens;

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
        
        private int _typeIndex = 0;
        public WordDisplay display;

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
            return word[_typeIndex];
        }

        public void TypeLetter()
        {
            _typeIndex++;
            EventManager.TriggerEvent("LetterTyped");
            if (display != null)
            {
                display.RemoveLetter();
            }
        }

        public bool WordTyped()
        {
            bool wordTyped = (_typeIndex >= word.Length);

            if (wordTyped)
            {
                EventManager.TriggerEvent("WordTyped");
            }
            
            if (wordTyped && display != null)
            {
                display.RemoveWord();
            }

            return wordTyped;
        }
    }
}

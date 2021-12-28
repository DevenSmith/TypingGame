namespace TypingGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WordManager : MonoBehaviour
    {
        [SerializeField]
        private List<Word> words = new List<Word>();

        [SerializeField] 
        private WordSpawner wordSpawner;
        
        private bool hasActiveWord;
        private Word activeWord;

        public void AddWord()
        {
            var word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
            words.Add(word);
        }

        public void TypeLetter(char letter)
        {
            if (hasActiveWord)
            {
                if (activeWord.GetNextLetter() == letter)
                {
                    activeWord.TypeLetter();
                }
            }
            else
            {
                foreach (var word in words)
                {
                    if (word.GetNextLetter() == letter)
                    {
                        activeWord = word;
                        hasActiveWord = true;
                        word.TypeLetter();
                        break;
                    }
                }
            }

            if (hasActiveWord && activeWord.WordTyped())
            {
                hasActiveWord = false;
                words.Remove(activeWord);
            }
            
            
        }
    }
}

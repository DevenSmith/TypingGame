using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TypingGame;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{

    public class WordTest
    {
        private Word word;
        
        // A Test behaves as an ordinary method
        [Test]
        public void WordTestSimplePasses()
        {
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator WordTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
        
        [Test]
        public void WordCreationTest()
        {
            word = new Word("test", null);
            Assert.True(word != null);
        }
        
        [Test]
        public void WordGetNextLetterTest()
        {
            word = new Word("test", null);
            Assert.True(word.GetNextLetter() == 't');
        }
        
        [Test]
        public void WordTypeLetterTest()
        {
            word = new Word("test", null);
            word.TypeLetter();
            Assert.True(word.GetNextLetter() == 'e');
        }
        
        [Test]
        public void WordNotTypedTest()
        {
            word = new Word("test", null);
            Assert.True(!word.WordTyped());
        }
        
        [Test]
        public void WordTypedTest()
        {
            string testWord = "test";
            word = new Word(testWord, null);
            for (int i = 0; i < testWord.Length; i++)
            {
                word.TypeLetter();
            }
            Assert.True(word.WordTyped());
        }
        

    }
}

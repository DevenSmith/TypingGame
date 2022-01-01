using System.Collections;
using System.Collections.Generic;
using Devens;
using NUnit.Framework;
using TMPro;
using TypingGame;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class WordDisplayTest
    {
        private GameObject displayObj;
        private WordDisplay display;
        
        [SetUp]
        public void Setup()
        {
            displayObj = new GameObject("WordDisplayTestObject");
            display = displayObj.AddComponent<WordDisplay>();
            display.Text = displayObj.AddComponent<TextMeshProUGUI>();
        }

        [TearDown]
        public void Teardown()
        {
            if (displayObj != null)
            {
                Object.DestroyImmediate(displayObj);
            }
        }
        
        
        // A Test behaves as an ordinary method
        [Test]
        public void WordDisplayTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator WordDisplayTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        [Test]
        public void WordDisplayCreateTest()
        {
            Assert.True(display != null);
        }
        
        [Test]
        public void WordDisplaySetWordTest()
        {
            string testWord = "test";
            display.SetWord(testWord);
            Assert.True(display.Text.text == testWord);
        }
        
        [Test]
        public void WordDisplayRemoveLetterTest()
        {
            string testWord = "test";
            display.SetWord(testWord);
            display.RemoveLetter();
            Assert.True(display.Text.text != testWord);
        }
    }
}

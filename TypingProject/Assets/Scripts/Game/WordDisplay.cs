using System;
using Devens;
using TMPro;

namespace TypingGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WordDisplay : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text text;

        [SerializeField]
        private FloatSO fallSpeed;
        
        public TMP_Text Text
        {
            get => text;
            set => text = value;
        }

        public FloatSO FallSpeed
        {
            get => fallSpeed;
            set => fallSpeed = value;
        }
        

        public void SetWord(string word)
        {
            text.text = word;
        }

        public void RemoveLetter()
        {
            text.text = text.text.Remove(0, 1);
            text.color = Color.red;
        }

        public void RemoveWord()
        {
            Destroy(gameObject);
        }

        private void Update()
        {
            transform.Translate(0f, -fallSpeed.Value * Time.deltaTime, 0.0f);
        }
    }
}

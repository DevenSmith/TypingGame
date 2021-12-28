﻿namespace TypingGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WordInput : MonoBehaviour
    {
        [SerializeField]
        private WordManager wordManager;
        // Update is called once per frame
        void Update()
        {
            foreach (var letter in Input.inputString)
            {
                wordManager.TypeLetter(letter);
            }
        }
    }
}

using System;
using Devens;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Game
{
    public class ScoreDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;

        private int _wordsTyped = 0;
        private int _lettersTyped = 0;
        
        private void Start()
        {
            UpdateDisplay();
            EventManager.StartListening("WordTyped", OnWordTyped);
            EventManager.StartListening("LetterTyped", OnLetterTyped);
        }

        private void OnDestroy()
        {
            EventManager.StopListening("WordTyped", OnWordTyped);
            EventManager.StopListening("LetterTyped", OnLetterTyped);
        }

        private void OnWordTyped()
        {
            _wordsTyped++;
            UpdateDisplay();
        }

        private void OnLetterTyped()
        {
            _lettersTyped++;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            scoreText.text = "Words Typed: " + _wordsTyped + "\n" +
            "Letters Typed: " + _lettersTyped;
        }
        
    }
}

namespace TypingGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WordSpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject wordPrefab;

        [SerializeField] 
        private Transform wordCanvas;
        public WordDisplay SpawnWord()
        {
            Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);
            
            var wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
            var wordDisplay = wordObj.GetComponent<WordDisplay>();
            return wordDisplay;
        }
    }
}

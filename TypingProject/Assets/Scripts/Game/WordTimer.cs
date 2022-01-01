using Devens;

namespace TypingGame
{
    using UnityEngine;

    public class WordTimer : MonoBehaviour
    {
        [SerializeField]
        private WordManager wordManager;

        [SerializeField]
        private FloatSO wordSpawnDelay;

        [SerializeField]
        private FloatSO spawnRateChange;

        private float nextWordTime = 0.0f;

        private void Start()
        {
            wordSpawnDelay = new FloatSO(wordSpawnDelay);
        }

        private void Update()
        {
            if (Time.time >= nextWordTime)
            {
                wordManager.AddWord();
                nextWordTime = Time.time + wordSpawnDelay.Value;
                wordSpawnDelay.Value *=  spawnRateChange.Value;
            }
        }
    }
}

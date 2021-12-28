namespace Devens
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml.Schema;
    using UnityEngine;

    [CreateAssetMenu]
    public class FloatSO : ScriptableObject
    {
        [SerializeField] private float floatValue;

        public FloatSO() { }

        public FloatSO(FloatSO original)
        {
            Value = original.Value;
        }

        public float Value
        {
            get { return floatValue; }
            set { floatValue = value; }
        }
    }
}

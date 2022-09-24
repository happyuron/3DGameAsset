using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAsset
{
    public class SoundManager : Singleton<SoundManager>
    {
        [SerializeField] private float maxSoundValue;

        public delegate void ValueChange();

        public ValueChange ValueChangeFunc;

        private float baseSound;

        public float BaseSound
        {
            get { return baseSound; }

            private set
            {
                baseSound = value;
                ValueChangeFunc();
            }
        }

        private float mainSound;

        public float MainSound
        {
            get { return mainSound; }

            private set
            {
                mainSound = value;
                ValueChangeFunc();
            }
        }

        private float effectSound;
        public float EffectSound
        {
            get { return effectSound; }

            private set
            {
                effectSound = value;
                ValueChangeFunc();
            }
        }



    }
}

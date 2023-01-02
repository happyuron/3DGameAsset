using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAsset
{
    public class SoundManager : Singleton<SoundManager>
    {
        [SerializeField] private float maxSoundValue;

        public delegate void SoundFunc();

        public SoundFunc BGMFunc, SFXFunc, MSFunc;


        private float bgmSound;

        public float BGMSound
        {
            get { return bgmSound; }
            private set
            {
                bgmSound = value;
                BGMFunc();
            }
        }

        private float mainSound;

        public float MainSound
        {
            get { return mainSound; }
            private set
            {
                mainSound = value;
                MSFunc();
            }
        }

        private float effectSound;
        public float EffectSound
        {
            get { return effectSound; }
            private set
            {
                effectSound = value;
                SFXFunc();
            }
        }

        protected override void Start()
        {
            // 사운드 함수 추가

        }




    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAsset
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {

        private static T instance;
        public static T Instance
        {
            get
            {
                if (instance == null) instance = FindObjectOfType<T>();
                return instance;
            }
            private set { instance = value; }
        }

        public bool dontDestroyOnLoad;

        protected virtual void Awake()
        {
            Init();
        }

        protected virtual void Init()
        {
            if (FindObjectsOfType<T>().Length > 1)
            {
                Destroy(gameObject);
                return;
            }
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(gameObject);
            }
        }

        protected virtual void Start()
        {

        }
    }

}

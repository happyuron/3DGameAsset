using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAsset
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        public static T Instance { get; private set; }

        public bool dontDestroyOnLoad;

        protected virtual void Awake()
        {
            if (FindObjectsOfType<T>().Length > 1)
            {
                Destroy(gameObject);
                return;
            }
            if (Instance == null)
            {
                Instance = GetComponent<T>();
            }
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(gameObject);
            }
        }

        protected virtual void Init()
        {

        }

        protected virtual void Start()
        {

        }
    }

}

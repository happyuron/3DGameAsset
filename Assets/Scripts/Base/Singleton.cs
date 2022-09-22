using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T Instance { get; private set; }

    public bool dontDestroyOnLoad;

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = GetComponent<T>();
        }
    }

    protected virtual void Init()
    {

    }

    protected virtual void Start()
    {

    }
}

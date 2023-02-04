using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPostProcesado : MonoBehaviour
{
    public static SingletonPostProcesado Instance2;
    private void Awake()
    {
        if (Instance2 == null)
        {
            Instance2 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (Instance2 != this)
            {
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {

    }


    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Object.DontDestroyOnLoad example.

public class DDOL : MonoBehaviour
{
    private static DDOL instance;
    void Awake()
     {
    
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
       
        DontDestroyOnLoad(this.gameObject);
    }
}
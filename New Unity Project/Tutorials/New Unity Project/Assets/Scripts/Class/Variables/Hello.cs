using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    int x = 5;
    int y = 6;
    void Start()

    {
        if (x + y < 10)
        {
            Debug.Log("no");
        }
        else
        {
            Debug.Log("I am smart");
        }
    }
    
}

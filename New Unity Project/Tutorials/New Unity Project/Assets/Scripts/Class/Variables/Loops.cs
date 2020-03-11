using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEnemies = 5;
    public int cupsInTheSink = 10;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= numEnemies; i++)
        {
            Debug.Log("Creating enemy number:" + i);
        }
        while(cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup");
            cupsInTheSink--;
        }
        bool shouldContinue = false;

        do
        {
            print("Hello World");
        } while (shouldContinue == true);
        string[] strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeEnemy : MonoBehaviour
{
    public float hp;
    private void Update()
    {
        if(hp<= 0)
        {
            Destroy(gameObject);
        }
    }
}

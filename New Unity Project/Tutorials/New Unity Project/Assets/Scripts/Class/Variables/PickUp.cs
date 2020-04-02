using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int pointsToAdd;
   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }
        
    }
}

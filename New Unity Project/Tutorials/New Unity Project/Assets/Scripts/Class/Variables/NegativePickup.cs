using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegativePickup : PickUp
{
    public int pointsToSub;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.SubPoints(pointsToSub);
            Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 20;
    public Transform spawnPoint;
    public float points = 10;
   
  
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        spawnPoint = GameObject.Find("SpawnPoint").transform; 
       
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            print("Enemy is dead!");
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            currentHealth = maxHealth;
        }
    }
     

}

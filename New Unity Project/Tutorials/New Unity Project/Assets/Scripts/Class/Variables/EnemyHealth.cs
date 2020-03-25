using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 20;
    public Transform spawnPoint;
    public float points = 10;
    public bool dead = false;
    
   
  
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        spawnPoint = GameObject.Find("SpawnPoint").transform;
       

       
    }
     private void Update()
    {
        
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            print("Enemy is dead!");
            dead = true;
           
        }
        if (dead == true)
        {
            Instantiate(gameObject);
            gameObject.transform.position = spawnPoint.position;
            gameObject.transform.rotation = spawnPoint.rotation;
            currentHealth = maxHealth;
        }
    }

    
        
   
      

}

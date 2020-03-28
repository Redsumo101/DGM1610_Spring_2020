using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 20;
     
    public float points = 10;
   
    
    
   
  
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
       
        

       
    }
     private void Update()
    {        
        if (currentHealth <= 0)
        {
            
            Destroy(gameObject);
            print("Enemy is dead!");
            
            
                            
        }

    }
   

    
        
   
      

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth = 20;
    public HealthBar healthBar;
     
    public float points = 10;
    public float damage = 1;
   
    
    
   
  
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        damage = 2;
        

       
    }
     private void Update()
    {        
        if (currentHealth <= 0)
        {
            
            Destroy(gameObject);
            print("Enemy is dead!");
            
            
                            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pellet"))
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
    }







}

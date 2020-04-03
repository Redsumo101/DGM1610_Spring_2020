using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int damage;
   
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health -= 10;
            print("I got damaged");
        }
    }
    // Update is called once per frame

    private void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
   
}

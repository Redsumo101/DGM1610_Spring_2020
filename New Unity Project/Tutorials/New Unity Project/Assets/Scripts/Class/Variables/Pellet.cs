using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    private EnemyHealth enemy;
    public int damage;
    private void Start()
    {
        enemy = GetComponent<EnemyHealth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemy.currentHealth -= 1;
        }
        
    }

    
}

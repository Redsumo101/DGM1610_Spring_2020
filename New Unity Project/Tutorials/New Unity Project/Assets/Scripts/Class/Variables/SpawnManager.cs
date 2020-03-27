using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    private EnemyHealth enemyHealth;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        spawnPoint = GameObject.Find("SpawnPoint").transform;
    }

    // Update is called once per frame
    public void Spawner()
    {
       
        if (enemyHealth.currentHealth <= 0) 
        {
            Instantiate(enemyPrefabs[enemyIndex], spawnPoint); 
        }
    }
}

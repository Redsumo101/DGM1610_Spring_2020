using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_2 : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatInterval = 2;
    private PlayerController_2 playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController_2>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}

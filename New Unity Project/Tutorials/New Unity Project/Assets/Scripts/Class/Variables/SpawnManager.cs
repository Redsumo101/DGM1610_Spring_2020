using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public int posX;
    public int posZ;
    public int enemyCount;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }
    IEnumerator EnemySpawn()
    { 
        while(enemyCount < 40)
        {
            posX = Random.Range(-40, 40);
            posZ = Random.Range(-40, 40);
            Instantiate(enemy, new Vector3(posX, 0, posZ), Quaternion.identity);
            yield return new WaitForSeconds(1);
            enemyCount += 1;
            
        }
    }

}

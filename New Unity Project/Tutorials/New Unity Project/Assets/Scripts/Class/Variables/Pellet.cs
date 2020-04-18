using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    public int time = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }
   

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

}

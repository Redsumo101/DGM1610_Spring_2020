using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 100;
   
    public int time = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<StatusEffectManager>() != null)
        {
            other.GetComponent<StatusEffectManager>().ApplyBurn(4);

        }
        Destroy(gameObject);


    }
     
   IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
     
}

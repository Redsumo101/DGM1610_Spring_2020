using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectManager : MonoBehaviour
{
    private EnemyHealth healthScript;
    public List<int> burnTickTimers = new List<int>();
    public int time;
    void Start()
    {
        healthScript = GetComponent<EnemyHealth>();

    }

    
    public void ApplyBurn(int ticks)
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("FireBullet"))
        {
            StartCoroutine(Burn());

        }
    }
    IEnumerator Burn()
    {
        print("Burn");
        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(time);
    }

}

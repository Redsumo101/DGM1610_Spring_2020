using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectManager : MonoBehaviour
{
    private EnemyHealth healthScript;
    public ParticleSystem explosionParticle;

    public List<int> burnTickTimers = new List<int>();
    public int time;
    void Start()
    {
        healthScript = GetComponent<EnemyHealth>();

    }

  
    public void ApplyBurn(int ticks)
    {
        if (burnTickTimers.Count <= 0)
        {
            burnTickTimers.Add(ticks);
            StartCoroutine(Burn());
        }
        else
        {
            burnTickTimers.Add(ticks);
        }
    }

    IEnumerator Burn()
    {
        while(burnTickTimers.Count > 0)
        {
            for(int i = 0; i < burnTickTimers.Count; i++)
            {
                burnTickTimers[i]--;
            }
            healthScript.currentHealth -= Random.Range(1, 5);
            burnTickTimers.RemoveAll(i => i == 0);
            GetComponent<Renderer>().material.color = Color.red;
            explosionParticle.Play();
            healthScript.healthBar.SetHealth(healthScript.currentHealth);
            print("Burn");
            yield return new WaitForSeconds(0.75f);
            
        }    
              
    }

}

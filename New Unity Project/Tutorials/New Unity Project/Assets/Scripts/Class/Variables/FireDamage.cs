using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : TakeDamage
{
    public int damage = 5;
    public float burnMin = 1;
    public float burnMax = 3;
    private EnemyHealth burnEffect;
    public int burnTime = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
        burnEffect = GameObject.Find("Enemy").GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    public void OnTriggerEnter(Collider other)
    {
        while (Time.deltaTime *burnTime >= 0) { 
            currentHealth + burnEffect
}
        if (other.gameObject.CompareTag("Enemy")) { 

           
    



        }
    }
    

}

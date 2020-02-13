using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
   public float bullets;
   public float shots_taken;
   public float reloads;
      
    // Start is called before the first frame update
    void Start()
    {
        Ammo(bullets, shots_taken, reloads);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Ammo(float bullets, float shots_taken, float reloads)
    {
       

        float total;
        total = bullets - shots_taken + reloads;
        if (bullets < 0)
        {
            Debug.Log(bullets + reloads);
        }
        print(total);
        }
}

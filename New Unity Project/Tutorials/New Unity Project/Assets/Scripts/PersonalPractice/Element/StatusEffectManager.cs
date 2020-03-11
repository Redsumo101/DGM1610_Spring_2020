using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectManager : MonoBehaviour
{
    private Health healthScript;
    void Start()
    {
        healthScript = GetComponent<Health>();

    }

    
    public void ApplyBurn(int ticks)
    {
        
    }
}

﻿
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera tpCam;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, tpCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}

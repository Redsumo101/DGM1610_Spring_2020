using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    public int pelletCount;
    public float spreadAngle;
    public GameObject pellet;
    List<Quaternion> pellets;
    public Transform Barrel;
    public float pelletSpeed = 1;
    public int time = 5;
    // Start is called before the first frame update
    void Awake()
    {
        pellets = new List<Quaternion>(pelletCount);
        for(int i = 0; i < pelletCount; i++)
        {
            pellets.Add(Quaternion.Euler(Vector3.zero));
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }
    void Fire()
    {
       
        for(int i = 0; i < pelletCount; i++)
        {
            pellets[i] = Random.rotation;
            GameObject p = Instantiate(pellet, Barrel.position, Barrel.rotation);
            p.transform.rotation = Quaternion.RotateTowards(p.transform.rotation, pellets[i], spreadAngle);
            p.GetComponent<Rigidbody>().AddForce(p.transform.forward * pelletSpeed);
            i++;
        }
    }
   
}

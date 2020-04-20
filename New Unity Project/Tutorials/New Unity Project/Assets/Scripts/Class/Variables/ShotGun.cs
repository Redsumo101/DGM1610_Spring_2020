using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    public int pelletCount;
    public float spreadAngle;
    public GameObject pellet;
    private float LifeTime = 1;
    List<Quaternion> pellets;
    public Transform Barrel;
    public float pelletSpeed = 1;
    public int time = 5;
    // Start is called before the first frame update
    void Awake()
    {
        pellets = new List<Quaternion>(new Quaternion [pelletCount]);
       

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
            GameObject p = new GameObject();
            pellets[i] = Random.rotation;
            p = (GameObject)Instantiate(pellet, Barrel.position, Barrel.rotation) as GameObject;
            Destroy(p, LifeTime);
            p.transform.rotation = Quaternion.RotateTowards(p.transform.rotation, pellets[i], spreadAngle);
            p.GetComponent<Rigidbody>().AddForce(p.transform.forward * pelletSpeed);
            i++;
        }
    }
   
}

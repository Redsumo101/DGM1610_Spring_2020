using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Reloading : MonoBehaviour
{
    public Text reloading;
    public Weapon weapon;
    public ShotGun shotgun;
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Start()
    {
        reloading.GetComponent<Text>().enabled = false;
        weapon.GetComponent<Weapon>().isReloading = false;
        shotgun.GetComponent<ShotGun>().isReloading = false;
    }

    private void Update()
    {
        if (shotgun.isReloading == true || weapon.isReloading == true)
        {
            reloading.GetComponent<Text>().enabled = true;
        }
        else
        {
            reloading.GetComponent<Text>().enabled = false;
        }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projectilePrefab;
    public int maxAmmo = 10;
    public int currentAmmo;
    public float reloadTime = 2f;
    public bool isReloading = false;
    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (isReloading)
        {
            return;
        }
        if(currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetKeyDown("r") && currentAmmo < maxAmmo)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            currentAmmo--;
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
    }
}

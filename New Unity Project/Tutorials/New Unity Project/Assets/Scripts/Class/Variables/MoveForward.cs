using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveForward : MonoBehaviour
{
    public float speed = 50;
    Vector3 direction;
    public GameObject player;
    public Image reticale;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = reticale.transform.position + Camera.main.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( direction  * Time.deltaTime * speed);
    }
}

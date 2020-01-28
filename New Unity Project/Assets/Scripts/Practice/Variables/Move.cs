using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed);

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Colliding with Floor");
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Colliding with Obstacle");
        }
        else
        {
            Debug.Log("...");
        }
    }
     void OnTriggerEnter(Collider other)
    {
        Debug.Log("You have entered the trigger!");
    }
}

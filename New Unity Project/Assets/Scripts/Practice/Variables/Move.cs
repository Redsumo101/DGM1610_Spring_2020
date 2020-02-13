using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed = 60;
    public float jumpHeight =0;
    public float jumpInput;
    public GameObject projectilePrefab;
    public int projectileCount;
    List<Quaternion> projectiles;

    // Start is called before the first frame update
    void Start()
    {
        projectiles = new List<Quaternion>(projectileCount);
        for (int i = 0; i < projectileCount; i++);


        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.forward * Time.deltaTime*speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * jumpHeight * jumpInput);

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            
        }

    }
  /* void OnCollisionEnter(Collision other)
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
    }*/
}

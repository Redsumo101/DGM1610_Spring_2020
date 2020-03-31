using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed = 120;
    private Rigidbody playerRb;
    public float jumpforce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public GameObject projectilePrefab;
    public int projectileCount;
    List<Quaternion> projectiles;

    // Start is called before the first frame update
    void Start()
    {
        projectiles = new List<Quaternion>(projectileCount);
        for (int i = 0; i < projectileCount; i++);

        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime*speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;
        }
       

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
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
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed = 120;
    public CharacterController controller;
    public float jumpforce = 10;
    public float gravityModifier = -10;
    public bool isOnGround = true;
    public GameObject projectilePrefab;
    public int projectileCount;
    List<Quaternion> projectiles;
    Vector3 velocity;
    public bool fireBullet = true;

    // Start is called before the first frame update
    void Start()
    {
        projectiles = new List<Quaternion>(projectileCount);
        for (int i = 0; i < projectileCount; i++);
        fireBullet = false;
       

        
    }

    // Update is called once per frame
    void Update()
    {
        if (fireBullet == false)
        {
            projectilePrefab = null;
        }

        if(isOnGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * horizontalInput + transform.forward * forwardInput;
        velocity.y += gravityModifier * Time.deltaTime;

        controller.Move(move * speed * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            velocity.y = Mathf.Sqrt(jumpforce * -2 * gravityModifier);
        }
       

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
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

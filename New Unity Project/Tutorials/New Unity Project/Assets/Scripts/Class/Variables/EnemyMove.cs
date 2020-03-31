using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target;
    public float moveSpeed;
    public int damage;
    private Rigidbody enemyRb;
    public GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        damage = 2;
        
    }
    
    // Update is called once per frame
    void Update()
    {
       
        transform.LookAt(target);

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (target.position.y > 0)
        {
            moveSpeed = 0;
        }
        else
        {
            moveSpeed = 5;
        }



    }
    private void FixedUpdate()
    {
        
        enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);
       
        

    }

}

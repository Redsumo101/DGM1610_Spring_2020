﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target;
    public float moveSpeed;
    public float damage;
    private Rigidbody enemyRb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.LookAt(target);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
      
    }
    private void FixedUpdate()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);
    }

}

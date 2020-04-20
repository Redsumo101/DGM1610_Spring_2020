using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wander : MonoBehaviour
{
    public float wanderRadius;
    public float wanderTimer;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    public float alertDist;
    public float attackDist;
    private float distance;
    private float speed = 10;
    public float damage;

    private Vector3 heading;

    

    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    private void Start()
    {
        distance = Vector3.Distance(target.position, transform.position);
    }

    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        if(distance < alertDist && distance > attackDist)
        {
            print("Enemy sees you");
            speed += 2;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if(distance <= alertDist)
        {
            heading = target.position - transform.position;
            heading.y = 0;
            speed += 5;
            transform.LookAt(target);
            transform.Translate((Vector3.forward * speed * Time.deltaTime));
            
            if(heading.magnitude <= attackDist)
            {
                var currentHealth = target.gameObject.GetComponent<Health>();
            }
        }



       
        else if (distance > alertDist) {
            timer += Time.deltaTime;
            if (timer >= wanderTimer)
            {
                Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
            } 
        }

    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;

    }
}

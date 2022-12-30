using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    private GameObject target;
    public GameObject[] obstacles;
    private float closestObstacle = 99999;

    void Start()
    {
        obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {
        //agent = GetComponent<NavMeshAgent>();
        for(int i = 0; i < obstacles.Length; i++)
        {
            float dist = Vector3.Distance(agent.transform.position, obstacles[i].transform.position);
            if(dist < closestObstacle)
            {
                closestObstacle = dist;
                target = obstacles[i];
            }
        }
        Invoke("destroyGameObject", 8.0f);
        //target = GameObject.FindGameObjectWithTag("Obstacle");
        agent.destination = target.transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            destroyGameObject();
        }
    }

    private void destroyGameObject()
    {
        Destroy(gameObject);
    }
}

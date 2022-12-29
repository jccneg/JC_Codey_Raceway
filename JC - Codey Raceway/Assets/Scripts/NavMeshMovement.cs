using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject target;
    private GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacles")

    // Update is called once per frame
    void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectsWithTag("Obstacle");
        agent.destination = target.transform.position;
        Invoke("destroyGameObject", 8.0f);
        
        for(int i = 0; i < obstacles; i++)
        {
            
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Invoke("destroyGameObject", 2.0f);
        }
    }

    private void destroyGameObject()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_Script : EnemyInh_Script
{
    private Transform dest;
    UnityEngine.AI.NavMeshAgent agent;
    private Transform player;
    
   

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (!agent)
        {//startup
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            agent.destination = RandomNavmeshLocation(150);
        }
        else
        {
            AiTree();
        }
    }

    public Vector3 RandomNavmeshLocation(float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        UnityEngine.AI.NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;

        if (UnityEngine.AI.NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }

    void AiTree()
    {
        if (Chase())
            agent.destination = player.position;
        else if (Wander())
            agent.destination = RandomNavmeshLocation(150);
    }

    bool Wander()
    {
        if ((agent.destination - this.gameObject.transform.position).magnitude < 10)
            return true;
        return false;
    }

    bool Chase()
    {
        if ((player.position - this.gameObject.transform.position).magnitude < 10)
            return true;

        return false;
    }
}
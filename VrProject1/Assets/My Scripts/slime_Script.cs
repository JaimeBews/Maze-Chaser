using UnityEngine;
using System.Collections;

public class slime_Script : EnemyInh_Script
{
    private Transform player;
    private Animator animController;

    UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        animController = GetComponent<Animator>();
    }

    void Update()
    {
        if (!agent)
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
        else
        {
            AiTree();
        }
		if (this.transform.position.y<-20)
			Destroy(this);
		
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

    private void AiTree()
    {
        if (Attack())
        {
            agent.destination = player.position;
            animController.SetBool("attacking", true);
        }
        else if (Wander())
        {
            agent.destination = RandomNavmeshLocation(120);
            animController.SetBool("attacking", false);
        }
    }

    private bool Wander()
    {
        if ((agent.destination - this.gameObject.transform.position).magnitude < 10)
            return true;
        return false;
    }

    private bool Attack()
    {
        if ((player.position - this.gameObject.transform.position).magnitude < 1)
        {
            return true;
        }
        return false;
    }
}
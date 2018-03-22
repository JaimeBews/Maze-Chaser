using UnityEngine;
using System.Collections;

public class skeleton_Script : MonoBehaviour
{
    private Animator animController;
    public Transform dest;
    public int health;
    public int damage;
    UnityEngine.AI.NavMeshAgent agent;

    void Awake()
    {
        dest = GameObject.FindWithTag("Player").transform;

        animController = GetComponent<Animator>();
    }

    void Update()
    {
        if (!agent)
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }

        agent.destination = dest.position;
        animController.SetBool("isAttacking", Attack());
    }

    private bool Attack()
    {
        if ((dest.position - this.gameObject.transform.position).magnitude < 1)
        {
            return true;
        }
        return false;
    }
}
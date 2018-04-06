using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInh_Script : MonoBehaviour
{
    protected int health;
    protected int damage;
    [SerializeField] private float slowAmount;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    // Use this for initialization
    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "slowGlyph")
        {
            navMeshAgent.speed *= slowAmount;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "slowGlyph")
        {
            navMeshAgent.speed *= 1 / slowAmount;
        }
    }
}
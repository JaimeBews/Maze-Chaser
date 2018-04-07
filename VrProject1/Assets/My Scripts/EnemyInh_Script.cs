using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInh_Script : MonoBehaviour
{
    public int health;
    public int damage;
    [SerializeField] private float slowAmount;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    // Use this for initialization
    void Start()
    {
        navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SGlyph")
        {
			Debug.Log("Skele touche");
            navMeshAgent.speed *= slowAmount;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "SGlyph")
        {
            navMeshAgent.speed *= 1 / slowAmount;
        }
    }
}
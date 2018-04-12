using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInh_Script : MonoBehaviour
{
    public int health;
    public int damage;
    [SerializeField] public float slowAmount;
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    // Use this for initialization
    void Start()
    {
        //  navMeshAgent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        //   slowAmount = .5f;
    }

    // Update is called once per frame
    void Update()
    {
        //   if (!navMeshAgent)
        //       navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    /*
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "SGlyph")
            {
                Debug.Log("Skele touche");
                navMeshAgent.speed *= slowAmount;
            }
            else
                return;
        }

        void OnTriggerExit(Collider other)
        {
            if (other.tag == "SGlyph")
            {
                navMeshAgent.speed *= 1 / slowAmount;
            }
            else
                return;
        }*/
}
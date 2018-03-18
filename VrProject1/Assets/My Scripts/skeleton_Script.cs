    using UnityEngine;
    using System.Collections;
    
    public class skeleton_Script : MonoBehaviour {
       
       public Transform dest;
       UnityEngine.AI.NavMeshAgent agent;
       void Start () {         
         dest = GameObject.FindWithTag("Player").transform;
       }
	   void Update(){
		   if (!agent){
			   agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		   }
		    agent.destination = dest.position; 
	   }
	   void AttackBehaviour(){
		   
		   
	   }
    }
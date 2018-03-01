using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag=="endTile")
			Destroy(other.gameObject);// what should happen when you win
    }
}

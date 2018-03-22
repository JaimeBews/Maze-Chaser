using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Script : MonoBehaviour
{
    public int health;
    // Use this for initialization
    void Start()
    {
        MonoBehaviour scripts = this.GetComponent<MonoBehaviour>();
        Debug.Log(scripts);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "endTile")
            Destroy(other.gameObject);// what should happen when you win
    }

    void onCollisionEnter(Collider other)
    {
        if (other.tag == "Zombie")
            health -= other.gameObject.GetComponent<zombie_Script>().damage;
        if (other.tag == "Skeleton")
            health -= other.gameObject.GetComponent<skeleton_Script>().damage;
        if (other.tag == "Slime")
            health -= other.gameObject.GetComponent<slime_Script>().damage;
    }
}
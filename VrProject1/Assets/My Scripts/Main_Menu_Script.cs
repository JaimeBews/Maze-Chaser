using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu_Script : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Use this for initialization

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        // this.gameObject.transform.LookAt(player.transform.position);
        transform.rotation = Quaternion.LookRotation(new Vector3(transform.position.x - player.transform.position.x, 1, transform.position.z - player.transform.position.z));
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Script : MonoBehaviour
{
    bool invulnerable = false;
    [SerializeField] private float iframes = 2;
    [SerializeField] private GameObject POGO;
    [SerializeField] private int Lives = 3;
    public int health;
    [SerializeField] private int maxHealth = 5;
    [SerializeField] private load_Level_Script LLS;
    [SerializeField] private Animator dragon;
    // Use this for initialization
    void Start()
    {
        dragon = GameObject.FindGameObjectWithTag("Dragon").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            playerDied();
            health = maxHealth;
        }
        if (this.gameObject.transform.position.y < -10)
            playerDied();
    }

    void playerDied()
    {
        if (Lives > 0)
        {
            Lives--;
            this.gameObject.transform.position = GameObject.FindGameObjectWithTag("startTile").transform.position;
        }
        else
            POGO.GetComponent<level_Controller>().StartGame();
    }

    void tookDamage()
    {
        invulnerable = true;
        StartCoroutine("invulSet");
    }

    IEnumerator invulSet()
    {
        invulnerable = true;
        yield return new WaitForSeconds(iframes);
        invulnerable = false;
    }

    bool Eating()
    {
        return true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "endTile")
        {
            dragon.SetBool("Eating", Eating());
            LLS.LoadLevel("Main");
        }
        if (other.tag == "Zombie" && !invulnerable)
        {
            health -= other.gameObject.GetComponent<zombie_Script>().damage;
            tookDamage();
        }
        if (other.tag == "Skeleton" && !invulnerable)
        {
            health -= other.gameObject.GetComponent<skeleton_Script>().damage;
            tookDamage();
        }
        if (other.tag == "Slime" && !invulnerable)
        {
            health -= other.gameObject.GetComponent<slime_Script>().damage;
            tookDamage();
        }
    }

}
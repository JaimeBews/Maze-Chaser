using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInh_Script : MonoBehaviour
{
    public int health;
    public int damage;
	public float speed;
	public float slowSpeed;
	public float maxSpeed;
	public AudioSource audioSource;
	public AudioClip hitGlyphSound;
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

    }
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SGlyph")
        {
			audioSource.clip = hitGlyphSound;
			audioSource.Play();
            StartCoroutine("Wait");
			Destroy(other.gameObject);
        }
    }
    IEnumerator Wait()
    {
        speed = slowSpeed;
        yield return new WaitForSeconds(3);
        speed = maxSpeed;
    }
}
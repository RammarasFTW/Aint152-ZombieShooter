using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour {
    public int health = 10;
    public GameObject explosionPrefab;
    public float adjustExplosionAngle = 0.0f;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Quaternion newRot = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + adjustExplosionAngle);
            Instantiate(explosionPrefab, transform.position, newRot);
            Destroy(gameObject);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

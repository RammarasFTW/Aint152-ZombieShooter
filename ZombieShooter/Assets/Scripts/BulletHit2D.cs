﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit2D : MonoBehaviour {
    public int damage = 1;
    public string damagetag ="";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(damagetag))
        {
            other.SendMessage("TakeDamage", damage);
        }
        Destroy(gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

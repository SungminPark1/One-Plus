﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowEnemy : MonoBehaviour {
    public Transform[] target;
    public float speed;
    private int current;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * 10, Space.Self);

		if (transform.position != target [current].position) {
			Vector3 pos = Vector3.MoveTowards (transform.position, target [current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody2D> ().MovePosition (pos);
		} else {
			Debug.Log("HIT");
			current = (current + 1) % target.Length;
		}
	}
}

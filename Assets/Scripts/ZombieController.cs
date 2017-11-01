﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour {
	GameObject player;

	Animator animator;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		agent = GetComponent<NavMeshAgent> ();
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (player.transform.position);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Debug.Log ("collision");
			animator.SetBool ("attack", true);
			agent.speed = 0.0f;
			agent.isStopped=true;


			}
		if (other.gameObject.tag == "axe") {
			Destroy (this.gameObject);
		}
		
	
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			animator.SetBool ("attack", false);
			agent.isStopped=false;
			agent.speed = 5.0f;
		}



	}

}

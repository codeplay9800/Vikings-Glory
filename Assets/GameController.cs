using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject enemy;
	public Transform[] spawnpoint;
	public float spawntime;
	Transform spawnpos;
	// Use this for initialization
	void Start () {
		StartCoroutine("spawn");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator spawn()
	{
		
		while (true) {
			spawnpos=spawnpoint[Random.Range(0,spawnpoint.Length)];
			Instantiate (enemy, spawnpos.position, spawnpos.rotation);
			yield return new WaitForSeconds (spawntime);
		}
	}
}

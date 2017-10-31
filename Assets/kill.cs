using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class kill : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();	
	}

	void Update ()
	{
	}

	// Update is called once per frame
	public void killyou () {
			anim.SetTrigger ("kill");
		}

}

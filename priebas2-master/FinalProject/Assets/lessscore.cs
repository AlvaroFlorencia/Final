using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lessscore : MonoBehaviour {
	public score score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		print ("tocandoenemigo");
		if (other.tag == "Player") {
			Destroy (gameObject);
			score.LessPoints ();

	}
}
}

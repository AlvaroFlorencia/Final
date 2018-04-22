using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour {

    public GameObject HalfLap;
	public GameObject CompleteLap;

	void OnTriggerEnter(){
		HalfLap.SetActive (true);
		CompleteLap.SetActive (false);
	}
}

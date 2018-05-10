using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

	public GameObject CountD;
	public AudioSource GetR;
	public AudioSource Go;
	public GameObject Timer;
	public CarCtrl Controls;
	// Use this for initialization
	void Start () {
		StartCoroutine (CountStart ());	
	}
	IEnumerator CountStart(){
        Controls.disableControls();
		Timer.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		CountD.GetComponent<Text> ().text = "3";
		GetR.Play ();
		CountD.SetActive (true);
		yield return new WaitForSeconds (1);
		CountD.SetActive (false);
		CountD.GetComponent<Text> ().text = "2";
		GetR.Play ();
		CountD.SetActive (true);
		yield return new WaitForSeconds (1);
		CountD.SetActive (false);
		CountD.GetComponent<Text> ().text = "1";
		GetR.Play ();
		CountD.SetActive (true);
		yield return new WaitForSeconds (1);
		CountD.SetActive (false);
		Go.Play ();
		Timer.SetActive (true);
        Controls.enableControls();
	}
	// Update is called once per frame
	void Update () {
		
	}
}

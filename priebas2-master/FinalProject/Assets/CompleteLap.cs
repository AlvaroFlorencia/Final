using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompleteLap : MonoBehaviour {


	public GameObject CompleteTrigger;
	public GameObject HalfTrigger;
	public GameObject MinDisplay;
	public GameObject SecDisplay;
	public GameObject MillDisplay;
	public GameObject LapTime;
	public Text Laps;
	public int lap=0;
	public int finall;
	public float RawTime;
	private LevelManager levelManager;
	void Update(){
		finall = lap / 4;
		Laps.text = finall.ToString();
		levelManager = FindObjectOfType<LevelManager>();

		if (finall>0) {
			levelManager.LoadNextLevel ();
		}
	
	
	}


	// Update is called once per frame
	void OnTriggerEnter () {
		levelManager.LoadNextLevel ();
		lap++;
		RawTime = PlayerPrefs.GetFloat ("RawTime");
		if (TimeL.RawTime <= RawTime) {
		
		
			if (TimeL.Sec <= 9) {
				SecDisplay.GetComponent<Text> ().text = "0" + TimeL.Sec + ".";	
	
			} else {
				SecDisplay.GetComponent<Text> ().text = "" + TimeL.Sec + ".";
			}

			if (TimeL.Minute <= 9) {
				MinDisplay.GetComponent<Text> ().text = "0" + TimeL.Minute + ".";	

			} else {
				MinDisplay.GetComponent<Text> ().text = "" + TimeL.Minute + ".";
			}
			MillDisplay.GetComponent<Text> ().text = "" + TimeL.Mili + ".";
		}
		PlayerPrefs.SetInt ("MinSave",	TimeL.Minute);
		PlayerPrefs.SetInt ("SecSave",	TimeL.Sec);
		PlayerPrefs.SetFloat ("MilliSave",	TimeL.Mili);
		PlayerPrefs.SetFloat ("RawTime",	TimeL.RawTime);



			TimeL.Minute = 0;
			TimeL.Sec = 0;
			TimeL.Mili = 0;
		TimeL.RawTime = 0;

			CompleteTrigger.SetActive (false);
			HalfTrigger.SetActive (true);

		
	}
}
